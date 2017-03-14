﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;

namespace XComponent.Order.Common
{
    public interface IInternalCommunication
    {
        void Init(string configFile);

        void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void Send(Context context, XComponent.Order.UserObject.OrderInput evt, string privateTopic = null);

        void Send(Context context, XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null);

        void Send(Context context, XComponent.Order.UserObject.ExecutionInput evt, string privateTopic = null);

        void Send(Context context, XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null);

        void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(XComponent.Order.UserObject.OrderInput evt, string privateTopic = null);

        void SendEvent(XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null);

        void SendEvent(XComponent.Order.UserObject.ExecutionInput evt, string privateTopic = null);

        void SendEvent(XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderInput evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.ExecutionInput evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null);

    }
}
