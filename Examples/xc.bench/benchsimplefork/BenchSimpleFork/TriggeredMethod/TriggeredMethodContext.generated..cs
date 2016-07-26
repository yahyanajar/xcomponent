// //-----------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by XCTools.
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------
namespace XComponent.BenchSimpleFork.TriggeredMethod
{
    using System;
    using XComponent.BenchSimpleFork.Common;
    using XComponent.BenchSimpleFork.Common.Senders;
    using XComponent.Common.TriggeredMethod;
    using XComponent.Common.Manager;
    using XComponent.Common.Logger;
    
    
    public partial class TriggeredMethodContext : ICustomTriggeredMethodContext
    {
        
        private static ICustomTriggeredMethodContext instance = new TriggeredMethodContext();
        
        static TriggeredMethodContext()
        {
        }
        
        private TriggeredMethodContext()
        {
        }
        
        public static ICustomTriggeredMethodContext Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        
        private ComponentManager componentManager;
        
        public IComponentManager ComponentManager
        {
            get
            {
                return componentManager;
            }
        }
        
        public XComponent.Common.Logger.IComponentLogger GetLogger(LogKeyEnum loggerName)
        {
				return  Loggers.GetLogger(loggerName);
        }
        
        public void Init(ComponentManager componentManager)
        {
				this.componentManager = componentManager;
				OnComponentInitialized();
        }
        
        public string GetParameterValue(KeyValueParametersEnum keyValueParameter)
        {
				if (componentManager.KeyValueParameters.IsKeyExists(keyValueParameter.ToString())) {
				return componentManager.KeyValueParameters.GetValue(keyValueParameter.ToString()); }
				return null;
        }
    }
    
    public partial interface ICustomTriggeredMethodContext : ITriggeredMethodContext
    {
        
        string GetParameterValue(KeyValueParametersEnum keyValueParameter);
        
        XComponent.Common.Logger.IComponentLogger GetLogger(LogKeyEnum loggerName);
        
        IComponentManager ComponentManager
        {
            get;
        }
    }
}
