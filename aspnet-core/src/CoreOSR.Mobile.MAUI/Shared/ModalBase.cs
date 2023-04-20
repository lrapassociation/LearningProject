﻿using CoreOSR.Core.Dependency;
using CoreOSR.Mobile.MAUI.Services.UI;

namespace CoreOSR.Mobile.MAUI.Shared
{
    public abstract class ModalBase : CoreOSRComponentBase
    {
        protected ModalManagerService ModalManager { get; set; }

        public abstract string ModalId { get; }

        public ModalBase()
        {
            ModalManager = DependencyResolver.Resolve<ModalManagerService>();
        }

        public virtual async Task Show()
        {
            await ModalManager.Show(JS, ModalId);
            StateHasChanged();
        }

        public virtual async Task Hide()
        {
            await ModalManager.Hide(JS, ModalId);
        }
    }
}
