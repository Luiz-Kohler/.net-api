﻿using Domain.Enums;

namespace Domain.Entities
{
    public class Chore : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EChoreStatus Status { get; set; }
    }
}
