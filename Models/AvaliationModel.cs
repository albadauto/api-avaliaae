﻿namespace api_avaliaae.Models
{
    public class AvaliationModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Note { get; set; }
        public UserModel User { get; set; }
        public InstitutionModel Institution { get; set; }
        public int UserId { get; set; }
        public int InstitutionId { get; set; }
    }
}
