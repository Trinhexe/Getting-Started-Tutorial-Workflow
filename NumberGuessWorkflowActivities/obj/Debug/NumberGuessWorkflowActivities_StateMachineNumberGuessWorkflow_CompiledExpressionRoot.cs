namespace NumberGuessWorkflowActivities {
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "E:\Workflow\NumberGuessWorkflowActivities\StateMachineNumberGuessWorkflow_du.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class StateMachineNumberGuessWorkflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly valDataContext0 = ((StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new StateMachineNumberGuessWorkflow_TypedDataContext3(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext3 refDataContext1 = ((StateMachineNumberGuessWorkflow_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext2 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext3 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new StateMachineNumberGuessWorkflow_TypedDataContext4(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4 refDataContext4 = ((StateMachineNumberGuessWorkflow_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new StateMachineNumberGuessWorkflow_TypedDataContext4(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4 refDataContext5 = ((StateMachineNumberGuessWorkflow_TypedDataContext4)(cachedCompiledDataContext[3]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext6 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext7 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext8 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext9 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext10 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 4);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext11 = ((StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext11.ValueType___Expr11Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly valDataContext0 = new StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                StateMachineNumberGuessWorkflow_TypedDataContext3 refDataContext1 = new StateMachineNumberGuessWorkflow_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<int>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext2 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext3 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4 refDataContext4 = new StateMachineNumberGuessWorkflow_TypedDataContext4(locations, true);
                return refDataContext4.GetLocation<int>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4 refDataContext5 = new StateMachineNumberGuessWorkflow_TypedDataContext4(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext6 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext7 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext8 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext9 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext10 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly valDataContext11 = new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new System.Random().Next(1, MaxNumber + 1);") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Target") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Please enter a number between 1 and \" + MaxNumber") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Turns + 1") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Turns") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Guess") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess == Target") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess.ToString() + \" is correct. You guessed it in \" + Turns.ToString() + \" turns" +
                            ".\"") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess != Target") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess < Target") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess.ToString() + \" is too low.\"") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess.ToString() + \" is too high.\"") 
                        && (StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext1 : StateMachineNumberGuessWorkflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Turns;
            
            protected int MaxNumber;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Turns = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.MaxNumber = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.Turns);
                this.SetVariableValue((1 + locationsOffset), this.MaxNumber);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Turns") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MaxNumber") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return StateMachineNumberGuessWorkflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly : StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Turns;
            
            protected int MaxNumber;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Turns = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.MaxNumber = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Turns") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MaxNumber") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return StateMachineNumberGuessWorkflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext2 : StateMachineNumberGuessWorkflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Guess;
            
            protected int Target;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Guess = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.Target = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.Guess);
                this.SetVariableValue((3 + locationsOffset), this.Target);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 2)].Name != "Guess") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Target") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return StateMachineNumberGuessWorkflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly : StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Guess;
            
            protected int Target;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Guess = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.Target = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 2)].Name != "Guess") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Target") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return StateMachineNumberGuessWorkflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext3 : StateMachineNumberGuessWorkflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 52 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 52 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                Target;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(int value) {
                
                #line 52 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                
                Target = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly : StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 57 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                new System.Random().Next(1, MaxNumber + 1);;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 57 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                new System.Random().Next(1, MaxNumber + 1);;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext4 : StateMachineNumberGuessWorkflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 77 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        Turns;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr4Get() {
                
                #line 77 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                        Turns;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(int value) {
                
                #line 77 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                
                        Turns = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 93 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Guess;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 93 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                            Guess;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 93 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                
                            Guess = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly : StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 69 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      "Please enter a number between 1 and " + MaxNumber;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 69 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                      "Please enter a number between 1 and " + MaxNumber;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 82 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        Turns + 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 82 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                        Turns + 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 109 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Guess == Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 109 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                      Guess == Target;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 104 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          Guess.ToString() + " is correct. You guessed it in " + Turns.ToString() + " turns.";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 104 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                          Guess.ToString() + " is correct. You guessed it in " + Turns.ToString() + " turns.";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 137 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Guess != Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 137 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                      Guess != Target;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 117 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Guess < Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 117 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                            Guess < Target;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 123 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Guess.ToString() + " is too low.";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 123 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                              Guess.ToString() + " is too low.";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 130 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Guess.ToString() + " is too high.";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 130 "E:\WORKFLOW\NUMBERGUESSWORKFLOWACTIVITIES\STATEMACHINENUMBERGUESSWORKFLOW_DU.XAML"
                return 
                              Guess.ToString() + " is too high.";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext5 : StateMachineNumberGuessWorkflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class StateMachineNumberGuessWorkflow_TypedDataContext5_ForReadOnly : StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public StateMachineNumberGuessWorkflow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return StateMachineNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
