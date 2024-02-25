// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using System;
using Demos.Orlando.ToDo.Brokers.Storages;
using Demos.Orlando.ToDo.Models.ToDoItems;
using Microsoft.AspNetCore.Components;

namespace Demos.Orlando.ToDo.Views.Components.TodoComponents
{
    public partial class TodoComponent : ComponentBase
    {
        [Inject]
        public IStorageBroker StorageBroker { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public Action OnAdded { get; set; }


        private async void AddItem()
        {
            var item = new ToDoItem()
            {
                Id = System.Guid.NewGuid()
                ,
                Title = Title
            };

           await StorageBroker.InsertToDoItemAsync(item);

            OnAdded.Invoke();
        }
    }
}