// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrame.ExampleProject {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.Serialization;
    using UnityEngine;
    using UniRx;
    
    
    public partial class LevelRootViewModelBase : uFrame.MVVM.ViewModel {
        
        private P<LevelDescriptor> _CurrentLevelProperty;
        
        private Signal<FinishCurrentLevelCommand> _FinishCurrentLevel;
        
        public LevelRootViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<LevelDescriptor> CurrentLevelProperty {
            get {
                return _CurrentLevelProperty;
            }
            set {
                _CurrentLevelProperty = value;
            }
        }
        
        public virtual LevelDescriptor CurrentLevel {
            get {
                return CurrentLevelProperty.Value;
            }
            set {
                CurrentLevelProperty.Value = value;
            }
        }
        
        public virtual Signal<FinishCurrentLevelCommand> FinishCurrentLevel {
            get {
                return _FinishCurrentLevel;
            }
            set {
                _FinishCurrentLevel = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.FinishCurrentLevel = new Signal<FinishCurrentLevelCommand>(this);
            _CurrentLevelProperty = new P<LevelDescriptor>(this, "CurrentLevel");
        }
        
        public virtual void ExecuteFinishCurrentLevel() {
            this.FinishCurrentLevel.OnNext(new FinishCurrentLevelCommand());
        }
        
        public override void Read(ISerializerStream stream) {
            base.Read(stream);
        }
        
        public override void Write(ISerializerStream stream) {
            base.Write(stream);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("FinishCurrentLevel", FinishCurrentLevel) { ParameterType = typeof(void) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_CurrentLevelProperty, false, false, false, false));
        }
    }
    
    public partial class LevelRootViewModel {
        
        public LevelRootViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
