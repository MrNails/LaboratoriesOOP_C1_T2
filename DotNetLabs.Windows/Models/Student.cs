using DotNetLabs.Windows.Services;

namespace DotNetLabs.Windows.Models;

public sealed class Student : BindableBase
{
    private int m_id;
    private byte m_course;
    private string m_fullName;
    private string m_group;
    private string m_department;
    private string m_speciality;

    public int Id
    {
        get => m_id;
        set => SetField(ref m_id, value);
    }

    public string FullName
    {
        get => m_fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Errors[nameof(FullName)] = "Full name cannot be empty.";
            }
            else
            {
                Errors[nameof(FullName)] = string.Empty;
            }
            
            SetField(ref m_fullName, value);
        }
    }

    public string Group
    {
        get => m_group;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Errors[nameof(Group)] = "Group cannot be empty.";
            }
            else
            {
                Errors[nameof(Group)] = string.Empty;
            }
            
            SetField(ref m_group, value);
        }
    }

    public string Department
    {
        get => m_department;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Errors[nameof(Department)] = "Department cannot be empty.";
            }
            else
            {
                Errors[nameof(Department)] = string.Empty;
            }
            
            SetField(ref m_department, value);
        }
    }

    public byte Course
    {
        get => m_course;
        set
        {
            if (value is 0 or >= 6)
            {
                Errors[nameof(Course)] = "Course must be between 1 and 6 including.";
            }
            else
            {
                Errors[nameof(Course)] = string.Empty;
            }
            
            SetField(ref m_course, value);
        }
    }

    public string Speciality
    {
        get => m_speciality;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Errors[nameof(Department)] = "Speciality cannot be empty.";
            }
            else
            {
                Errors[nameof(Department)] = string.Empty;
            }
            
            SetField(ref m_speciality, value);
        }
    }
}