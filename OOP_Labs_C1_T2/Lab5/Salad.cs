using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using OOP_Labs_C1_T2.Lab5.Vegetables;

namespace OOP_Labs_C1_T2.Lab5;

public class Salad : IGetCalories
{
    private float m_totalCalories;
    private ObservableCollection<Vegetable> m_vegetables;

    public Salad()
    {
        m_totalCalories = 0.0f;
        
        m_vegetables = new ObservableCollection<Vegetable>();
        
        m_vegetables.CollectionChanged += VegetablesOnCollectionChanged;
    }

    public ObservableCollection<Vegetable> Vegetables => m_vegetables;

    public float GetCalories()
    {
        return m_totalCalories;
    }
    
    private void VegetablesOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                m_totalCalories += ((Vegetable)e.NewItems[0]).GetCalories();
                break;
            case NotifyCollectionChangedAction.Remove:
                m_totalCalories -= ((Vegetable)e.OldItems[0]).GetCalories();
                break;
        }
    }
}