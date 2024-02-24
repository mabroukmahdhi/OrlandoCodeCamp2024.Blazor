// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. All rights reserved.
// Presented w/ love at Orlando Code Camp 2024.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace Demos.Orlando.ToDo.Views.Components.NavmenuComponents
{
    public partial class NavmenuComponent : ComponentBase
    {
        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}