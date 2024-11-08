﻿namespace Coach.Core.Models
{
    public class CoachModel
    {
        private CoachModel(Guid id, string fullName, string email, string passwordHash, List<Group> groups/* List<Lesson>? lessons*/)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
            Groups = groups;
            //Lessons = lessons;
        }

        public Guid Id { get; }
        public string FullName { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string PasswordHash { get; } = string.Empty;
        public List<Group> Groups { get; } = [];
        //public List<Lesson> Lessons { get; } = [];

        public static (CoachModel Coach, string Error) Create(Guid id, string fullName, string email,
            string passwordHash, List<Group> groups/*, List<Lesson>? lessons*/)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(fullName))
            {
                error = "FullName can't be empty!";
            }

            var coach = new CoachModel(id, fullName,email,passwordHash, groups/*, lessons*/);

            return (coach, error);

        }
    }
}
