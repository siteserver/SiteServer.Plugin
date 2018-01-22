
using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public class InputType : IEquatable<InputType>, IComparable<InputType>
    {
        public static readonly InputType Text = new InputType(nameof(Text));
        public static readonly InputType TextArea = new InputType(nameof(TextArea));
        public static readonly InputType TextEditor = new InputType(nameof(TextEditor));
        public static readonly InputType CheckBox = new InputType(nameof(CheckBox));
        public static readonly InputType Radio = new InputType(nameof(Radio));
        public static readonly InputType SelectOne = new InputType(nameof(SelectOne));
        public static readonly InputType SelectMultiple = new InputType(nameof(SelectMultiple));
        public static readonly InputType SelectCascading = new InputType(nameof(SelectCascading));
        public static readonly InputType Date = new InputType(nameof(Date));
        public static readonly InputType DateTime = new InputType(nameof(DateTime));
        public static readonly InputType Image = new InputType(nameof(Image));
        public static readonly InputType Video = new InputType(nameof(Video));
        public static readonly InputType File = new InputType(nameof(File));
        public static readonly InputType Customize = new InputType(nameof(Customize));
        public static readonly InputType Hidden = new InputType(nameof(Hidden));

        private InputType(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        public string Value { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as InputType);
        }

        public static bool operator ==(InputType a, InputType b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object)a == null || (object)b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(InputType a, InputType b)
        {
            return !(a == b);
        }

        public bool Equals(InputType other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return
                Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(InputType other)
        {

            if (other == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return StringComparer.OrdinalIgnoreCase.Compare(Value, other.Value);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Value);
        }

        public override string ToString()
        {
            return Value;
        }

        public static string GetText(InputType type)
        {
            if (type == CheckBox)
            {
                return "复选框";
            }
            if (type == Radio)
            {
                return "单选框";
            }
            if (type == SelectOne)
            {
                return "下拉列表(单选)";
            }
            if (type == SelectMultiple)
            {
                return "下拉列表(多选)";
            }
            if (type == SelectCascading)
            {
                return "下拉列表(级联)";
            }
            if (type == Date)
            {
                return "日期选择框";
            }
            if (type == DateTime)
            {
                return "日期时间选择框";
            }
            if (type == Image)
            {
                return "图片";
            }
            if (type == Video)
            {
                return "视频";
            }
            if (type == File)
            {
                return "附件";
            }
            if (type == Text)
            {
                return "文本框(单行)";
            }
            if (type == TextArea)
            {
                return "文本框(多行)";
            }
            if (type == TextEditor)
            {
                return "内容编辑器";
            }
            if (type == Customize)
            {
                return "自定义";
            }
            if (type == Hidden)
            {
                return "隐藏";
            }

            throw new Exception();
        }
    }
}
