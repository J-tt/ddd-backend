﻿using System;
using System.ComponentModel;

namespace DDD.Core.Domain
{
    public class Session
    {
        public Guid Id { get; set; }
        public string ExternalId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public Guid[] PresenterIds { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public SessionFormat Format { get; set; }
        public string Level { get; set; }
        public string[] Tags { get; set; }
        public string MobilePhoneContact { get; set; }

        public bool DataEquals(Session p)
        {
            return Title == p.Title
                && Abstract == p.Abstract
                && string.Join(",", PresenterIds) == string.Join(",", p.PresenterIds)
                && Format == p.Format
                && Level == p.Level
                && string.Join("|", Tags) == string.Join("|", p.Tags)
                && MobilePhoneContact == p.MobilePhoneContact;
        }
    }

    public enum SessionFormat
    {
        [Description("20 mins (15 mins talking)")]
        LightningTalk,
        [Description("45 mins (40 mins talking)")]
        FullTalk,
        [Description("Workshop")]
        Workshop
    }
}