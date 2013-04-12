using System;
using System.Collections.Generic;
[Serializable()]
public class ComboboxItem : IComparable<ComboboxItem>
{
   
    public int CompareTo(ComboboxItem other)
    {
        if (other == null) return 1;
        return Text.CompareTo(other.Text);
    }


    public ComboboxItem(string text, object value)
    {
        Text = text;
        Value = value;
    }

    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text;
    }
   
}

