namespace LearnDesign_Pattern.Facade_Patterns
{
    public class RegistrationFacade
    {
        private RegisterCourse _registerCourse;
        private NotifyStudent _notifyStudent;

        public RegistrationFacade()
        {
            _registerCourse=new RegisterCourse();
            _notifyStudent=new NotifyStudent();
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!_registerCourse.CheckAvailable(courseName))
            {
                return false;
            }

            return _notifyStudent.Notify(studentName);
        }
    }
}