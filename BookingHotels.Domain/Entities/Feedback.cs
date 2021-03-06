﻿using BookingHotels.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookingHotels.Domain.Entities
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public Guid HotelId { get; set; }
        public string FeedbackText { get; set; }
        public FeedbackStars FeedbackStars { get; set; }
        // Links to user and hotel, which had a feedback
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
