namespace LearnDesign_Pattern.Facade_Patterns
{
    public class RegistrationFacade
    {
        private readonly NotifyStudent _notifyStudent;
        private readonly RegisterCourse _registerCourse;

        public RegistrationFacade()
        {
            _registerCourse = new RegisterCourse();
            _notifyStudent = new NotifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!_registerCourse.CheckAvailable(courseName)) return false;

            return _notifyStudent.Notify(studentName);
        }
    }
}