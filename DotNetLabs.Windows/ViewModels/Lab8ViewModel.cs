using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DotNetLabs.Windows.Models;
using DotNetLabs.Windows.Services;

namespace DotNetLabs.Windows.ViewModels;

public sealed class Lab8ViewModel : BindableBase
{
    private readonly Lab8Repository m_repository;
    private Student? m_selectedStudent;

    public Lab8ViewModel()
    {
        Students = new ObservableCollection<Student>();
        m_repository = new Lab8Repository("data source=DESKTOP-U6JULRK;initial catalog=Test;integrated security=true;Persist Security Info=true;MultipleActiveResultSets=True;TrustServerCertificate=true;MultiSubnetFailover=True");

        RefreshStudentsCommand = new RelayCommand(RefreshStudents);
        CreateEmptyStudentCommand = new RelayCommand(CreateEmptyStudent);
        ClearSelectedStudentCommand = new RelayCommand(ClearSelectedStudent);
        AddStudentCommand = new RelayCommand<Student>(AddStudent!, st => st != null);
        UpdateStudentCommand = new RelayCommand<Student>(UpdateStudent!, st => st != null);
        DeleteStudentCommand = new RelayCommand<Student>(DeleteStudent!, st => st != null);

        RefreshStudents();
    }

    public ObservableCollection<Student> Students { get; }
    
    public ICommand RefreshStudentsCommand { get; }
    public ICommand CreateEmptyStudentCommand { get; }
    public ICommand ClearSelectedStudentCommand { get; }
    public ICommand AddStudentCommand { get; }
    public ICommand UpdateStudentCommand { get; }
    public ICommand DeleteStudentCommand { get; }

    public Student? SelectedStudent
    {
        get => m_selectedStudent;
        set
        {
            if (m_selectedStudent?.Id == -1)
            {
                Students.Remove(m_selectedStudent);
            }
            
            SetField(ref m_selectedStudent, value);
        }
    }

    private void RefreshStudents()
    {
        try
        {
            Students.Clear();

            foreach (var student in m_repository.GetAllStudents())
            {
                Students.Add(student);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot refresh student. {e.Message}", "Error", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void CreateEmptyStudent()
    {
        var newStudent = new Student { Id = -1 };
        Students.Add(newStudent);
        SelectedStudent = newStudent;
    }
    
    private void ClearSelectedStudent()
    {
        SelectedStudent = null;
    }
    
    private void AddStudent(Student student)
    {
        try
        {
            m_repository.AddStudent(student);
            
            MessageBox.Show("Student created.", "Information", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot add student. {e.Message}", "Error", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void UpdateStudent(Student student)
    {
        try
        {
            m_repository.UpdateStudent(student);
            MessageBox.Show("Student updated.", "Information", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot update student. {e.Message}", "Error", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void DeleteStudent(Student student)
    {
        try
        {
            Students.Remove(student);
            m_repository.RemoveStudent(student);
            MessageBox.Show("Student deleted.", "Information", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot delete student. {e.Message}", "Error", 
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}