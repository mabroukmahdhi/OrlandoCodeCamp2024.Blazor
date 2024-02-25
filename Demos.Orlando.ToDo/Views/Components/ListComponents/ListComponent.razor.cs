// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demos.Orlando.ToDo.Brokers.Storages;
using Demos.Orlando.ToDo.Models.ToDoItems;
using Microsoft.AspNetCore.Components;

namespace Demos.Orlando.ToDo.Views.Components.ListComponents
{
    public partial class ListComponent : ComponentBase
    {
        [Inject]
        public IStorageBroker StorageBroker { get; set; }

        public string Title { get; set; }

        protected override void OnInitialized()
        {
            Items = StorageBroker.SelectAllToDoItems()?.ToList();

        }
        public List<ToDoItem> Items { get; set; }

        void HandleOnAdded()
        {
            Items = StorageBroker.SelectAllToDoItems()?.ToList();
            StateHasChanged();
        }
    }
}