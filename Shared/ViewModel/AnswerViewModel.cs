﻿using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModel
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Answer is required!")]
        public string Answer { get; set; } = null!;
        public bool IsCorrectAnswer { get; set; }
        public int QuestionId { get; set; }
        public QuestionViewModel Question { get; set; } = null!;
    }
}
