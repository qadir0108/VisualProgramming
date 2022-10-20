namespace _20220613_Interfaces.Interfaces
{
    public interface IPerson
    {
        void Register();
        void Show();
    }

    public interface IStudent : IPerson
    {
        void Studies();
    }

    public interface ITeacher : IPerson
    {
        void Teaches();
    }

    // Any class that implements this interface must write code for these functions
    // Register and Show from IPerson
    // Studies from IStudent
    // Teaches from ITeacher
    // MarksAssignments from this interface
    public interface ITeachingAssistant : IStudent, ITeacher
    {
        void MarksAssignments();
    }
}
