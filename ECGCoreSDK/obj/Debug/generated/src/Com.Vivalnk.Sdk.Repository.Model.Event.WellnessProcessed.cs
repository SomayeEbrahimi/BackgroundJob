using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Model.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/event/WellnessProcessed", DoNotGenerateAcw=true)]
	public partial class WellnessProcessed : global::Com.Vivalnk.Sdk.Repository.Model.Event {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/event/WellnessProcessed", typeof (WellnessProcessed));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected WellnessProcessed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/constructor[@name='WellnessProcessed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WellnessProcessed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getActivityScore;
#pragma warning disable 0169
		static Delegate GetGetActivityScoreHandler ()
		{
			if (cb_getActivityScore == null)
				cb_getActivityScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetActivityScore);
			return cb_getActivityScore;
		}

		static int n_GetActivityScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivityScore;
		}
#pragma warning restore 0169

		static Delegate cb_setActivityScore_I;
#pragma warning disable 0169
		static Delegate GetSetActivityScore_IHandler ()
		{
			if (cb_setActivityScore_I == null)
				cb_setActivityScore_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetActivityScore_I);
			return cb_setActivityScore_I;
		}

		static void n_SetActivityScore_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActivityScore = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ActivityScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getActivityScore' and count(parameter)=0]"
			[Register ("getActivityScore", "()I", "GetGetActivityScoreHandler")]
			get {
				const string __id = "getActivityScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setActivityScore' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActivityScore", "(I)V", "GetSetActivityScore_IHandler")]
			set {
				const string __id = "setActivityScore.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getArtifactPercent;
#pragma warning disable 0169
		static Delegate GetGetArtifactPercentHandler ()
		{
			if (cb_getArtifactPercent == null)
				cb_getArtifactPercent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetArtifactPercent);
			return cb_getArtifactPercent;
		}

		static int n_GetArtifactPercent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArtifactPercent;
		}
#pragma warning restore 0169

		static Delegate cb_setArtifactPercent_I;
#pragma warning disable 0169
		static Delegate GetSetArtifactPercent_IHandler ()
		{
			if (cb_setArtifactPercent_I == null)
				cb_setArtifactPercent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetArtifactPercent_I);
			return cb_setArtifactPercent_I;
		}

		static void n_SetArtifactPercent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArtifactPercent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ArtifactPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getArtifactPercent' and count(parameter)=0]"
			[Register ("getArtifactPercent", "()I", "GetGetArtifactPercentHandler")]
			get {
				const string __id = "getArtifactPercent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setArtifactPercent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setArtifactPercent", "(I)V", "GetSetArtifactPercent_IHandler")]
			set {
				const string __id = "setArtifactPercent.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCorrectedHr;
#pragma warning disable 0169
		static Delegate GetGetCorrectedHrHandler ()
		{
			if (cb_getCorrectedHr == null)
				cb_getCorrectedHr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCorrectedHr);
			return cb_getCorrectedHr;
		}

		static int n_GetCorrectedHr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CorrectedHr;
		}
#pragma warning restore 0169

		static Delegate cb_setCorrectedHr_I;
#pragma warning disable 0169
		static Delegate GetSetCorrectedHr_IHandler ()
		{
			if (cb_setCorrectedHr_I == null)
				cb_setCorrectedHr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCorrectedHr_I);
			return cb_setCorrectedHr_I;
		}

		static void n_SetCorrectedHr_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CorrectedHr = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CorrectedHr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getCorrectedHr' and count(parameter)=0]"
			[Register ("getCorrectedHr", "()I", "GetGetCorrectedHrHandler")]
			get {
				const string __id = "getCorrectedHr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setCorrectedHr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCorrectedHr", "(I)V", "GetSetCorrectedHr_IHandler")]
			set {
				const string __id = "setCorrectedHr.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentState;
#pragma warning disable 0169
		static Delegate GetGetCurrentStateHandler ()
		{
			if (cb_getCurrentState == null)
				cb_getCurrentState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentState);
			return cb_getCurrentState;
		}

		static int n_GetCurrentState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentState;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentState_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentState_IHandler ()
		{
			if (cb_setCurrentState_I == null)
				cb_setCurrentState_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCurrentState_I);
			return cb_setCurrentState_I;
		}

		static void n_SetCurrentState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentState = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getCurrentState' and count(parameter)=0]"
			[Register ("getCurrentState", "()I", "GetGetCurrentStateHandler")]
			get {
				const string __id = "getCurrentState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setCurrentState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentState", "(I)V", "GetSetCurrentState_IHandler")]
			set {
				const string __id = "setCurrentState.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnergyExpenditure;
#pragma warning disable 0169
		static Delegate GetGetEnergyExpenditureHandler ()
		{
			if (cb_getEnergyExpenditure == null)
				cb_getEnergyExpenditure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEnergyExpenditure);
			return cb_getEnergyExpenditure;
		}

		static int n_GetEnergyExpenditure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnergyExpenditure;
		}
#pragma warning restore 0169

		static Delegate cb_setEnergyExpenditure_I;
#pragma warning disable 0169
		static Delegate GetSetEnergyExpenditure_IHandler ()
		{
			if (cb_setEnergyExpenditure_I == null)
				cb_setEnergyExpenditure_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetEnergyExpenditure_I);
			return cb_setEnergyExpenditure_I;
		}

		static void n_SetEnergyExpenditure_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnergyExpenditure = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int EnergyExpenditure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getEnergyExpenditure' and count(parameter)=0]"
			[Register ("getEnergyExpenditure", "()I", "GetGetEnergyExpenditureHandler")]
			get {
				const string __id = "getEnergyExpenditure.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setEnergyExpenditure' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEnergyExpenditure", "(I)V", "GetSetEnergyExpenditure_IHandler")]
			set {
				const string __id = "setEnergyExpenditure.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnergyExpenditureCumulative;
#pragma warning disable 0169
		static Delegate GetGetEnergyExpenditureCumulativeHandler ()
		{
			if (cb_getEnergyExpenditureCumulative == null)
				cb_getEnergyExpenditureCumulative = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEnergyExpenditureCumulative);
			return cb_getEnergyExpenditureCumulative;
		}

		static int n_GetEnergyExpenditureCumulative (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnergyExpenditureCumulative;
		}
#pragma warning restore 0169

		static Delegate cb_setEnergyExpenditureCumulative_I;
#pragma warning disable 0169
		static Delegate GetSetEnergyExpenditureCumulative_IHandler ()
		{
			if (cb_setEnergyExpenditureCumulative_I == null)
				cb_setEnergyExpenditureCumulative_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetEnergyExpenditureCumulative_I);
			return cb_setEnergyExpenditureCumulative_I;
		}

		static void n_SetEnergyExpenditureCumulative_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnergyExpenditureCumulative = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int EnergyExpenditureCumulative {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getEnergyExpenditureCumulative' and count(parameter)=0]"
			[Register ("getEnergyExpenditureCumulative", "()I", "GetGetEnergyExpenditureCumulativeHandler")]
			get {
				const string __id = "getEnergyExpenditureCumulative.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setEnergyExpenditureCumulative' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEnergyExpenditureCumulative", "(I)V", "GetSetEnergyExpenditureCumulative_IHandler")]
			set {
				const string __id = "setEnergyExpenditureCumulative.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEpoc;
#pragma warning disable 0169
		static Delegate GetGetEpocHandler ()
		{
			if (cb_getEpoc == null)
				cb_getEpoc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEpoc);
			return cb_getEpoc;
		}

		static int n_GetEpoc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Epoc;
		}
#pragma warning restore 0169

		static Delegate cb_setEpoc_I;
#pragma warning disable 0169
		static Delegate GetSetEpoc_IHandler ()
		{
			if (cb_setEpoc_I == null)
				cb_setEpoc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetEpoc_I);
			return cb_setEpoc_I;
		}

		static void n_SetEpoc_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Epoc = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Epoc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getEpoc' and count(parameter)=0]"
			[Register ("getEpoc", "()I", "GetGetEpocHandler")]
			get {
				const string __id = "getEpoc.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setEpoc' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEpoc", "(I)V", "GetSetEpoc_IHandler")]
			set {
				const string __id = "setEpoc.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSleepQualityIndex;
#pragma warning disable 0169
		static Delegate GetGetMaxSleepQualityIndexHandler ()
		{
			if (cb_getMaxSleepQualityIndex == null)
				cb_getMaxSleepQualityIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxSleepQualityIndex);
			return cb_getMaxSleepQualityIndex;
		}

		static int n_GetMaxSleepQualityIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSleepQualityIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxSleepQualityIndex_I;
#pragma warning disable 0169
		static Delegate GetSetMaxSleepQualityIndex_IHandler ()
		{
			if (cb_setMaxSleepQualityIndex_I == null)
				cb_setMaxSleepQualityIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxSleepQualityIndex_I);
			return cb_setMaxSleepQualityIndex_I;
		}

		static void n_SetMaxSleepQualityIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxSleepQualityIndex = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxSleepQualityIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMaxSleepQualityIndex' and count(parameter)=0]"
			[Register ("getMaxSleepQualityIndex", "()I", "GetGetMaxSleepQualityIndexHandler")]
			get {
				const string __id = "getMaxSleepQualityIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMaxSleepQualityIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSleepQualityIndex", "(I)V", "GetSetMaxSleepQualityIndex_IHandler")]
			set {
				const string __id = "setMaxSleepQualityIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximalHr;
#pragma warning disable 0169
		static Delegate GetGetMaximalHrHandler ()
		{
			if (cb_getMaximalHr == null)
				cb_getMaximalHr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaximalHr);
			return cb_getMaximalHr;
		}

		static int n_GetMaximalHr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximalHr;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximalHr_I;
#pragma warning disable 0169
		static Delegate GetSetMaximalHr_IHandler ()
		{
			if (cb_setMaximalHr_I == null)
				cb_setMaximalHr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaximalHr_I);
			return cb_setMaximalHr_I;
		}

		static void n_SetMaximalHr_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximalHr = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MaximalHr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMaximalHr' and count(parameter)=0]"
			[Register ("getMaximalHr", "()I", "GetGetMaximalHrHandler")]
			get {
				const string __id = "getMaximalHr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMaximalHr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximalHr", "(I)V", "GetSetMaximalHr_IHandler")]
			set {
				const string __id = "setMaximalHr.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximalMET;
#pragma warning disable 0169
		static Delegate GetGetMaximalMETHandler ()
		{
			if (cb_getMaximalMET == null)
				cb_getMaximalMET = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetMaximalMET);
			return cb_getMaximalMET;
		}

		static double n_GetMaximalMET (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximalMET;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximalMET_D;
#pragma warning disable 0169
		static Delegate GetSetMaximalMET_DHandler ()
		{
			if (cb_setMaximalMET_D == null)
				cb_setMaximalMET_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetMaximalMET_D);
			return cb_setMaximalMET_D;
		}

		static void n_SetMaximalMET_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximalMET = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double MaximalMET {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMaximalMET' and count(parameter)=0]"
			[Register ("getMaximalMET", "()D", "GetGetMaximalMETHandler")]
			get {
				const string __id = "getMaximalMET.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMaximalMET' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaximalMET", "(D)V", "GetSetMaximalMET_DHandler")]
			set {
				const string __id = "setMaximalMET.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximalMETminutes;
#pragma warning disable 0169
		static Delegate GetGetMaximalMETminutesHandler ()
		{
			if (cb_getMaximalMETminutes == null)
				cb_getMaximalMETminutes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaximalMETminutes);
			return cb_getMaximalMETminutes;
		}

		static int n_GetMaximalMETminutes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximalMETminutes;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximalMETminutes_I;
#pragma warning disable 0169
		static Delegate GetSetMaximalMETminutes_IHandler ()
		{
			if (cb_setMaximalMETminutes_I == null)
				cb_setMaximalMETminutes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaximalMETminutes_I);
			return cb_setMaximalMETminutes_I;
		}

		static void n_SetMaximalMETminutes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximalMETminutes = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MaximalMETminutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMaximalMETminutes' and count(parameter)=0]"
			[Register ("getMaximalMETminutes", "()I", "GetGetMaximalMETminutesHandler")]
			get {
				const string __id = "getMaximalMETminutes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMaximalMETminutes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximalMETminutes", "(I)V", "GetSetMaximalMETminutes_IHandler")]
			set {
				const string __id = "setMaximalMETminutes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximalMETpercentage;
#pragma warning disable 0169
		static Delegate GetGetMaximalMETpercentageHandler ()
		{
			if (cb_getMaximalMETpercentage == null)
				cb_getMaximalMETpercentage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaximalMETpercentage);
			return cb_getMaximalMETpercentage;
		}

		static int n_GetMaximalMETpercentage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximalMETpercentage;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximalMETpercentage_I;
#pragma warning disable 0169
		static Delegate GetSetMaximalMETpercentage_IHandler ()
		{
			if (cb_setMaximalMETpercentage_I == null)
				cb_setMaximalMETpercentage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaximalMETpercentage_I);
			return cb_setMaximalMETpercentage_I;
		}

		static void n_SetMaximalMETpercentage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximalMETpercentage = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MaximalMETpercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMaximalMETpercentage' and count(parameter)=0]"
			[Register ("getMaximalMETpercentage", "()I", "GetGetMaximalMETpercentageHandler")]
			get {
				const string __id = "getMaximalMETpercentage.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMaximalMETpercentage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximalMETpercentage", "(I)V", "GetSetMaximalMETpercentage_IHandler")]
			set {
				const string __id = "setMaximalMETpercentage.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMeanMAD;
#pragma warning disable 0169
		static Delegate GetGetMeanMADHandler ()
		{
			if (cb_getMeanMAD == null)
				cb_getMeanMAD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMeanMAD);
			return cb_getMeanMAD;
		}

		static int n_GetMeanMAD (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeanMAD;
		}
#pragma warning restore 0169

		static Delegate cb_setMeanMAD_I;
#pragma warning disable 0169
		static Delegate GetSetMeanMAD_IHandler ()
		{
			if (cb_setMeanMAD_I == null)
				cb_setMeanMAD_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMeanMAD_I);
			return cb_setMeanMAD_I;
		}

		static void n_SetMeanMAD_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MeanMAD = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MeanMAD {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMeanMAD' and count(parameter)=0]"
			[Register ("getMeanMAD", "()I", "GetGetMeanMADHandler")]
			get {
				const string __id = "getMeanMAD.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMeanMAD' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMeanMAD", "(I)V", "GetSetMeanMAD_IHandler")]
			set {
				const string __id = "setMeanMAD.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimalHr;
#pragma warning disable 0169
		static Delegate GetGetMinimalHrHandler ()
		{
			if (cb_getMinimalHr == null)
				cb_getMinimalHr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinimalHr);
			return cb_getMinimalHr;
		}

		static int n_GetMinimalHr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimalHr;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimalHr_I;
#pragma warning disable 0169
		static Delegate GetSetMinimalHr_IHandler ()
		{
			if (cb_setMinimalHr_I == null)
				cb_setMinimalHr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMinimalHr_I);
			return cb_setMinimalHr_I;
		}

		static void n_SetMinimalHr_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimalHr = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MinimalHr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getMinimalHr' and count(parameter)=0]"
			[Register ("getMinimalHr", "()I", "GetGetMinimalHrHandler")]
			get {
				const string __id = "getMinimalHr.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setMinimalHr' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinimalHr", "(I)V", "GetSetMinimalHr_IHandler")]
			set {
				const string __id = "setMinimalHr.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRelaxStressIntensity;
#pragma warning disable 0169
		static Delegate GetGetRelaxStressIntensityHandler ()
		{
			if (cb_getRelaxStressIntensity == null)
				cb_getRelaxStressIntensity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRelaxStressIntensity);
			return cb_getRelaxStressIntensity;
		}

		static int n_GetRelaxStressIntensity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RelaxStressIntensity;
		}
#pragma warning restore 0169

		static Delegate cb_setRelaxStressIntensity_I;
#pragma warning disable 0169
		static Delegate GetSetRelaxStressIntensity_IHandler ()
		{
			if (cb_setRelaxStressIntensity_I == null)
				cb_setRelaxStressIntensity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRelaxStressIntensity_I);
			return cb_setRelaxStressIntensity_I;
		}

		static void n_SetRelaxStressIntensity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RelaxStressIntensity = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RelaxStressIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getRelaxStressIntensity' and count(parameter)=0]"
			[Register ("getRelaxStressIntensity", "()I", "GetGetRelaxStressIntensityHandler")]
			get {
				const string __id = "getRelaxStressIntensity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setRelaxStressIntensity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRelaxStressIntensity", "(I)V", "GetSetRelaxStressIntensity_IHandler")]
			set {
				const string __id = "setRelaxStressIntensity.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRespirationRate;
#pragma warning disable 0169
		static Delegate GetGetRespirationRateHandler ()
		{
			if (cb_getRespirationRate == null)
				cb_getRespirationRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRespirationRate);
			return cb_getRespirationRate;
		}

		static int n_GetRespirationRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RespirationRate;
		}
#pragma warning restore 0169

		static Delegate cb_setRespirationRate_I;
#pragma warning disable 0169
		static Delegate GetSetRespirationRate_IHandler ()
		{
			if (cb_setRespirationRate_I == null)
				cb_setRespirationRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRespirationRate_I);
			return cb_setRespirationRate_I;
		}

		static void n_SetRespirationRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RespirationRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RespirationRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getRespirationRate' and count(parameter)=0]"
			[Register ("getRespirationRate", "()I", "GetGetRespirationRateHandler")]
			get {
				const string __id = "getRespirationRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setRespirationRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRespirationRate", "(I)V", "GetSetRespirationRate_IHandler")]
			set {
				const string __id = "setRespirationRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSleepEnd;
#pragma warning disable 0169
		static Delegate GetIsSleepEndHandler ()
		{
			if (cb_isSleepEnd == null)
				cb_isSleepEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSleepEnd);
			return cb_isSleepEnd;
		}

		static bool n_IsSleepEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepEnd_Z;
#pragma warning disable 0169
		static Delegate GetSetSleepEnd_ZHandler ()
		{
			if (cb_setSleepEnd_Z == null)
				cb_setSleepEnd_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSleepEnd_Z);
			return cb_setSleepEnd_Z;
		}

		static void n_SetSleepEnd_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepEnd = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool SleepEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='isSleepEnd' and count(parameter)=0]"
			[Register ("isSleepEnd", "()Z", "GetIsSleepEndHandler")]
			get {
				const string __id = "isSleepEnd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setSleepEnd' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSleepEnd", "(Z)V", "GetSetSleepEnd_ZHandler")]
			set {
				const string __id = "setSleepEnd.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSleepEndCandidate;
#pragma warning disable 0169
		static Delegate GetIsSleepEndCandidateHandler ()
		{
			if (cb_isSleepEndCandidate == null)
				cb_isSleepEndCandidate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSleepEndCandidate);
			return cb_isSleepEndCandidate;
		}

		static bool n_IsSleepEndCandidate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepEndCandidate;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepEndCandidate_Z;
#pragma warning disable 0169
		static Delegate GetSetSleepEndCandidate_ZHandler ()
		{
			if (cb_setSleepEndCandidate_Z == null)
				cb_setSleepEndCandidate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSleepEndCandidate_Z);
			return cb_setSleepEndCandidate_Z;
		}

		static void n_SetSleepEndCandidate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepEndCandidate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool SleepEndCandidate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='isSleepEndCandidate' and count(parameter)=0]"
			[Register ("isSleepEndCandidate", "()Z", "GetIsSleepEndCandidateHandler")]
			get {
				const string __id = "isSleepEndCandidate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setSleepEndCandidate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSleepEndCandidate", "(Z)V", "GetSetSleepEndCandidate_ZHandler")]
			set {
				const string __id = "setSleepEndCandidate.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSleepQualityIndex;
#pragma warning disable 0169
		static Delegate GetGetSleepQualityIndexHandler ()
		{
			if (cb_getSleepQualityIndex == null)
				cb_getSleepQualityIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSleepQualityIndex);
			return cb_getSleepQualityIndex;
		}

		static int n_GetSleepQualityIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepQualityIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepQualityIndex_I;
#pragma warning disable 0169
		static Delegate GetSetSleepQualityIndex_IHandler ()
		{
			if (cb_setSleepQualityIndex_I == null)
				cb_setSleepQualityIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSleepQualityIndex_I);
			return cb_setSleepQualityIndex_I;
		}

		static void n_SetSleepQualityIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepQualityIndex = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SleepQualityIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getSleepQualityIndex' and count(parameter)=0]"
			[Register ("getSleepQualityIndex", "()I", "GetGetSleepQualityIndexHandler")]
			get {
				const string __id = "getSleepQualityIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setSleepQualityIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSleepQualityIndex", "(I)V", "GetSetSleepQualityIndex_IHandler")]
			set {
				const string __id = "setSleepQualityIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSleepStart;
#pragma warning disable 0169
		static Delegate GetIsSleepStartHandler ()
		{
			if (cb_isSleepStart == null)
				cb_isSleepStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSleepStart);
			return cb_isSleepStart;
		}

		static bool n_IsSleepStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepStart;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepStart_Z;
#pragma warning disable 0169
		static Delegate GetSetSleepStart_ZHandler ()
		{
			if (cb_setSleepStart_Z == null)
				cb_setSleepStart_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSleepStart_Z);
			return cb_setSleepStart_Z;
		}

		static void n_SetSleepStart_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepStart = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool SleepStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='isSleepStart' and count(parameter)=0]"
			[Register ("isSleepStart", "()Z", "GetIsSleepStartHandler")]
			get {
				const string __id = "isSleepStart.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setSleepStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSleepStart", "(Z)V", "GetSetSleepStart_ZHandler")]
			set {
				const string __id = "setSleepStart.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStressBalance;
#pragma warning disable 0169
		static Delegate GetGetStressBalanceHandler ()
		{
			if (cb_getStressBalance == null)
				cb_getStressBalance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStressBalance);
			return cb_getStressBalance;
		}

		static int n_GetStressBalance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StressBalance;
		}
#pragma warning restore 0169

		static Delegate cb_setStressBalance_I;
#pragma warning disable 0169
		static Delegate GetSetStressBalance_IHandler ()
		{
			if (cb_setStressBalance_I == null)
				cb_setStressBalance_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStressBalance_I);
			return cb_setStressBalance_I;
		}

		static void n_SetStressBalance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StressBalance = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int StressBalance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getStressBalance' and count(parameter)=0]"
			[Register ("getStressBalance", "()I", "GetGetStressBalanceHandler")]
			get {
				const string __id = "getStressBalance.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setStressBalance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStressBalance", "(I)V", "GetSetStressBalance_IHandler")]
			set {
				const string __id = "setStressBalance.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainingEffect;
#pragma warning disable 0169
		static Delegate GetGetTrainingEffectHandler ()
		{
			if (cb_getTrainingEffect == null)
				cb_getTrainingEffect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTrainingEffect);
			return cb_getTrainingEffect;
		}

		static int n_GetTrainingEffect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrainingEffect;
		}
#pragma warning restore 0169

		static Delegate cb_setTrainingEffect_I;
#pragma warning disable 0169
		static Delegate GetSetTrainingEffect_IHandler ()
		{
			if (cb_setTrainingEffect_I == null)
				cb_setTrainingEffect_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTrainingEffect_I);
			return cb_setTrainingEffect_I;
		}

		static void n_SetTrainingEffect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrainingEffect = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TrainingEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getTrainingEffect' and count(parameter)=0]"
			[Register ("getTrainingEffect", "()I", "GetGetTrainingEffectHandler")]
			get {
				const string __id = "getTrainingEffect.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setTrainingEffect' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrainingEffect", "(I)V", "GetSetTrainingEffect_IHandler")]
			set {
				const string __id = "setTrainingEffect.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainingLoadPeak;
#pragma warning disable 0169
		static Delegate GetGetTrainingLoadPeakHandler ()
		{
			if (cb_getTrainingLoadPeak == null)
				cb_getTrainingLoadPeak = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTrainingLoadPeak);
			return cb_getTrainingLoadPeak;
		}

		static int n_GetTrainingLoadPeak (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrainingLoadPeak;
		}
#pragma warning restore 0169

		static Delegate cb_setTrainingLoadPeak_I;
#pragma warning disable 0169
		static Delegate GetSetTrainingLoadPeak_IHandler ()
		{
			if (cb_setTrainingLoadPeak_I == null)
				cb_setTrainingLoadPeak_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTrainingLoadPeak_I);
			return cb_setTrainingLoadPeak_I;
		}

		static void n_SetTrainingLoadPeak_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessProcessed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrainingLoadPeak = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TrainingLoadPeak {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='getTrainingLoadPeak' and count(parameter)=0]"
			[Register ("getTrainingLoadPeak", "()I", "GetGetTrainingLoadPeakHandler")]
			get {
				const string __id = "getTrainingLoadPeak.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessProcessed']/method[@name='setTrainingLoadPeak' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrainingLoadPeak", "(I)V", "GetSetTrainingLoadPeak_IHandler")]
			set {
				const string __id = "setTrainingLoadPeak.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
