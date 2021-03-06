// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed group management type.</para>
    /// </summary>
    public class GroupChangeManagementTypeDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupChangeManagementTypeDetails> Encoder = new GroupChangeManagementTypeDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupChangeManagementTypeDetails> Decoder = new GroupChangeManagementTypeDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="GroupChangeManagementTypeDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New group management type.</param>
        /// <param name="previousValue">Previous group management type. Might be missing due to
        /// historical data gap.</param>
        public GroupChangeManagementTypeDetails(global::Dropbox.Api.TeamCommon.GroupManagementType newValue,
                                                global::Dropbox.Api.TeamCommon.GroupManagementType previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="GroupChangeManagementTypeDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupChangeManagementTypeDetails()
        {
        }

        /// <summary>
        /// <para>New group management type.</para>
        /// </summary>
        public global::Dropbox.Api.TeamCommon.GroupManagementType NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous group management type. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public global::Dropbox.Api.TeamCommon.GroupManagementType PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupChangeManagementTypeDetails" />.</para>
        /// </summary>
        private class GroupChangeManagementTypeDetailsEncoder : enc.StructEncoder<GroupChangeManagementTypeDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupChangeManagementTypeDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamCommon.GroupManagementType.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamCommon.GroupManagementType.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupChangeManagementTypeDetails" />.</para>
        /// </summary>
        private class GroupChangeManagementTypeDetailsDecoder : enc.StructDecoder<GroupChangeManagementTypeDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="GroupChangeManagementTypeDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupChangeManagementTypeDetails Create()
            {
                return new GroupChangeManagementTypeDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupChangeManagementTypeDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamCommon.GroupManagementType.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamCommon.GroupManagementType.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
