﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace FirstTier.Data
{
    public class ConfirmBase: ComponentBase
    {
        protected bool ShowConfirmation { get; set; }

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}