// See https://aka.ms/new-console-template for more information
using Model;
using System.ComponentModel;
using ViewModel;

UsersDB udb = new UsersDB();
Users_List uList = udb.SelectAll();
foreach (Users u in uList)
    Console.WriteLine(u.Role);