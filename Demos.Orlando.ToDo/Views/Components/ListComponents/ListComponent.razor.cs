// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using System.Collections.Generic;
using Demos.Orlando.ToDo.Models.ToDoItems;
using Microsoft.AspNetCore.Components;

namespace Demos.Orlando.ToDo.Views.Components.ListComponents
{
    public partial class ListComponent : ComponentBase
    { 
    public List<ToDoItem> Items { get; set; }
    }
}