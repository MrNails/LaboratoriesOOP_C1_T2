using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using DotNetLabs.Windows.Models;
using Microsoft.Data.SqlClient;

namespace DotNetLabs.Windows.Services;

public sealed class Lab8Repository : IDisposable
{
    private readonly SqlConnection m_sqlConnection;

    public Lab8Repository(string connectionString)
    {
        m_sqlConnection = new SqlConnection(connectionString);
        m_sqlConnection.Open();
    }
    
    public IEnumerable<Student> GetAllStudents()
    {
        return m_sqlConnection.Query<Student>("SELECT * FROM Students");
    }

    public bool AddStudent(Student student)
    {
        var maxId = m_sqlConnection.Query<int?>("SELECT MAX(Id) + 1 FROM Students")?.FirstOrDefault() ?? 1;

        student.Id = maxId;

        return m_sqlConnection.Execute("INSERT INTO Students VALUES (@Id, @FullName, @Group, @Department, @Course, @Speciality)", student) > 0;
    }

    public bool UpdateStudent(Student student)
    {
        return m_sqlConnection.Execute("UPDATE Students SET FullName = @FullName, [Group] = @Group, Department = @Department, Course = @Course, Speciality =  @Speciality WHERE Id = @Id", student) > 0;
    }

    public bool RemoveStudent(Student student)
    {
        return m_sqlConnection.Execute("DELETE FROM Students WHERE Id = @Id", student) > 0;
    }

    public void Dispose()
    {
        m_sqlConnection.Dispose();
    }
}