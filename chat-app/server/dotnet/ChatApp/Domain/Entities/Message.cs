﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Message
{
    public Guid Id { get; set; }

    public Guid SenderId { get; set; }

    public Guid ReceiverId { get; set; }

    public Guid? GroupId { get; set; }

    public string Content { get; set; }

    public List<string> Type { get; set; }

    public string Status { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual Group Group { get; set; }

    public virtual User Receiver { get; set; }

    public virtual User Sender { get; set; }
}