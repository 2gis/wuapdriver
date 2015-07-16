﻿namespace Winium.StoreApps.InnerServer.Commands
{
    #region

    using Winium.StoreApps.Common;
    using Winium.StoreApps.InnerServer.Element;

    #endregion

    internal class DisplayedCommand : CommandBase
    {
        #region Public Properties

        public string ElementId { get; set; }

        #endregion

        #region Public Methods and Operators

        public override string DoImpl()
        {
            var element = this.Automator.WebElements.GetRegisteredElement(this.ElementId);
            var displayed = new WiniumElement(element).IsUserVisible(this.Automator.VisualRoot);

            return this.JsonResponse(ResponseStatus.Success, displayed);
        }

        #endregion
    }
}
