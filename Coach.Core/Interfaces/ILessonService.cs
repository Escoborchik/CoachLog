﻿using Coach.Core.Models;

namespace Coach.Core.Interfaces
{
    public interface ILessonService
    {
        Task<List<Lesson>> CreateLesson(Guid coachId, Guid groupId, short price, DateOnly date, TimeOnly time);
        Task<List<Lesson>> GetCoachLessons(Guid coachId);
        Task<Guid> DeleteLesson(Guid id);
        Task<List<Lesson>> GetAllLessons();
    }
}