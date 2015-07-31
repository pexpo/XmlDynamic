﻿namespace XmlDynamic
{
    using System;

    public class FieldValue
    {
        public Guid Id { get; set; }
    }

    public class FieldValue<T> : FieldValue
    {
        public FieldValue(Guid id, object value)
        {
            Id = id;
            Value = (T)value;
        }

        public T Value { get; set; }
    }
}