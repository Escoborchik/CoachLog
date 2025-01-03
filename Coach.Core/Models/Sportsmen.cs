﻿namespace Coach.Core.Models
{
    public class Sportsmen
    {
        private Sportsmen(Guid id, string userName, string passwordHash, string fullName,
            bool isMale, DateOnly birthday, int category, DateOnly beginnning,
            string address, string contacts,List<PayInformation> payInformation, List<Attendance> attendance, Group gruop)
        {
            Id = id;
            UserName = userName;
            PasswordHash = passwordHash;
            FullName = fullName;
            IsMale = isMale;
            Birthday = birthday;
            Category = category;
            Beginnning = beginnning;
            Address = address;
            Contacts = contacts;
            Attendance = attendance;
            PayInformations = payInformation;
            Group = gruop;

        }

        private Sportsmen(Guid id, Guid coachId, string userName, string passwordHash, string fullName, int category, DateOnly beginnning)
        {
            Id = id;
            UserName = userName;
            PasswordHash = passwordHash;
            FullName = fullName;            
            Category = category;
            Beginnning = beginnning;
            CoachId = coachId;
        }

        private Sportsmen(Guid id, string fullName)
        {
            Id = id;            
            FullName = fullName;            
        }

        public Guid Id { get; }
        public string UserName { get; } = string.Empty;
        public string PasswordHash { get; } = string.Empty;
        public string FullName { get; } = string.Empty;
        public bool IsMale { get; }
        public DateOnly Birthday { get; }
        public int Category { get; }
        public DateOnly Beginnning { get; }
        public string Address { get; } = string.Empty;
        public string Contacts { get; } = string.Empty;
        public List<PayInformation> PayInformations { get; }
        public List<Attendance> Attendance { get; } = [];
        public Group Group { get; }
        public Guid CoachId { get; }

        public static (Sportsmen Sportsmen, string Error) Create(Guid id, string userName, string passwordHash, string fullName,
            bool isMale, DateOnly birthday, int category, DateOnly beginnning,
            string address, string contacts, List<PayInformation> payInformation, List<Attendance> attendance, Group group)
        {
            var error = string.Empty;

            var sportsmen = new Sportsmen(id, userName,passwordHash,fullName,isMale,birthday,
                category,beginnning,address, contacts,payInformation,attendance,group);

            return (sportsmen, error);

        }

        public static (Sportsmen Sportsmen, string Error) Create(Guid id, Guid coachId, string userName,
            string passwordHash, string fullName, int category, DateOnly beginnning)
        {
            var error = string.Empty;

            var sportsmen = new Sportsmen(id, coachId, userName,passwordHash,fullName,category,beginnning);

            return (sportsmen, error);

        }

        public static (Sportsmen Sportsmen, string Error) Create(Guid id,string fullName)
        {
            var error = string.Empty;

            var sportsmen = new Sportsmen(id,fullName);

            return (sportsmen, error);

        }
    }
}