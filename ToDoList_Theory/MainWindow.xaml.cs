﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList_Theory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ToDoItem> Tasks { get; set; } = new ObservableCollection<ToDoItem>();
        public MainWindow()
        {
            InitializeComponent();
            TaskListLb.ItemsSource = Tasks;
        }

        private void AddTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            // IsNullOrWhiteSpace() - проверяет, то что строка NULL или пустая
            if (!string.IsNullOrWhiteSpace(TaskInputTb.Text))
            {
                Tasks.Add(new ToDoItem { Title = TaskInputTb.Text, IsDone = false });
                TaskInputTb.Text = string.Empty; // string.Empty - очищает строку
            }
        }

        private void DeleteTaskBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChechBox_Changed (object sender, RoutedEventArgs e)
        {

        }

        public class ToDoItem
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }

        }
        }
    }
