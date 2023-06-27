﻿using System.ComponentModel.DataAnnotations;

namespace TodoApiDTO.Data
{
    #region snippet
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
    #endregion
}