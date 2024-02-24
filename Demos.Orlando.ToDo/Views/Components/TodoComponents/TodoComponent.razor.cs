// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace Demos.Orlando.ToDo.Views.Components.TodoComponents
{
    public partial class TodoComponent : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        private void AddItem()
        {

        }
    }
}