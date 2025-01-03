﻿namespace Coach.DAL.Entities
{
    public class CoachEntity
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public List<GroupEntity> Groups { get; set; } = [];
        public List<SportsmenEntity> Sportsmens { get; set; } = [];
        public List<LessonEntity> Lessons { get; set; } = [];
    }
}
