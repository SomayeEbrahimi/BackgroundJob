using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/Event", DoNotGenerateAcw=true)]
	public partial class Event : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/field[@name='extras']"
		[Register ("extras")]
		public string Extras {
			get {
				const string __id = "extras.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "extras.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/field[@name='flash']"
		[Register ("flash")]
		public bool Flash {
			get {
				const string __id = "flash.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "flash.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/model/Event$EventType", DoNotGenerateAcw=true)]
		public sealed partial class EventType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='AFib']"
			[Register ("AFib")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType AFib {
				get {
					const string __id = "AFib.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='Activity']"
			[Register ("Activity")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType Activity {
				get {
					const string __id = "Activity.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='Normal']"
			[Register ("Normal")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType Normal {
				get {
					const string __id = "Normal.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='Pause']"
			[Register ("Pause")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType Pause {
				get {
					const string __id = "Pause.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='Unclassified']"
			[Register ("Unclassified")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType Unclassified {
				get {
					const string __id = "Unclassified.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Vivalnk.Sdk.Model.Event.EventType Unknown {
				get {
					const string __id = "Unknown.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/Event$EventType", typeof (EventType));
			internal static IntPtr class_ref {
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

			internal EventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/constructor[@name='Event.EventType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe EventType (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/Event$EventType;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.Event.EventType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/Event$EventType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.EventType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/sdk/model/Event$EventType;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.Event.EventType[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/sdk/model/Event$EventType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Sdk.Model.Event.EventType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.Event.EventType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/model/Event$Tag", DoNotGenerateAcw=true)]
		public sealed partial class Tag : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/field[@name='Append']"
			[Register ("Append")]
			public static global::Com.Vivalnk.Sdk.Model.Event.Tag Append {
				get {
					const string __id = "Append.Lcom/vivalnk/sdk/model/Event$Tag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/field[@name='End']"
			[Register ("End")]
			public static global::Com.Vivalnk.Sdk.Model.Event.Tag End {
				get {
					const string __id = "End.Lcom/vivalnk/sdk/model/Event$Tag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/field[@name='Start']"
			[Register ("Start")]
			public static global::Com.Vivalnk.Sdk.Model.Event.Tag Start {
				get {
					const string __id = "Start.Lcom/vivalnk/sdk/model/Event$Tag;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/Event$Tag", typeof (Tag));
			internal static IntPtr class_ref {
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

			internal Tag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/constructor[@name='Event.Tag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe Tag (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/Event$Tag;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.Event.Tag ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/Event$Tag;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event.Tag']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/vivalnk/sdk/model/Event$Tag;", "")]
			public static unsafe global::Com.Vivalnk.Sdk.Model.Event.Tag[] Values ()
			{
				const string __id = "values.()[Lcom/vivalnk/sdk/model/Event$Tag;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Vivalnk.Sdk.Model.Event.Tag[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.Event.Tag));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/Event", typeof (Event));
		internal static IntPtr class_ref {
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

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/constructor[@name='Event' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Event ()
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

		static Delegate cb_getAvgHeartRate;
#pragma warning disable 0169
		static Delegate GetGetAvgHeartRateHandler ()
		{
			if (cb_getAvgHeartRate == null)
				cb_getAvgHeartRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetAvgHeartRate);
			return cb_getAvgHeartRate;
		}

		static double n_GetAvgHeartRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvgHeartRate;
		}
#pragma warning restore 0169

		public virtual unsafe double AvgHeartRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getAvgHeartRate' and count(parameter)=0]"
			[Register ("getAvgHeartRate", "()D", "GetGetAvgHeartRateHandler")]
			get {
				const string __id = "getAvgHeartRate.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDataList;
#pragma warning disable 0169
		static Delegate GetGetDataListHandler ()
		{
			if (cb_getDataList == null)
				cb_getDataList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataList);
			return cb_getDataList;
		}

		static IntPtr n_GetDataList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (__this.DataList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> DataList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getDataList' and count(parameter)=0]"
			[Register ("getDataList", "()Ljava/util/ArrayList;", "GetGetDataListHandler")]
			get {
				const string __id = "getDataList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Device Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lcom/vivalnk/sdk/model/Device;", "GetGetDeviceHandler")]
			get {
				const string __id = "getDevice.()Lcom/vivalnk/sdk/model/Device;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEndTime);
			return cb_getEndTime;
		}

		static IntPtr n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/lang/Long;", "GetGetEndTimeHandler")]
			get {
				const string __id = "getEndTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetEventId);
			return cb_getEventId;
		}

		static long n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EventId;
		}
#pragma warning restore 0169

		static Delegate cb_setEventId_J;
#pragma warning disable 0169
		static Delegate GetSetEventId_JHandler ()
		{
			if (cb_setEventId_J == null)
				cb_setEventId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetEventId_J);
			return cb_setEventId_J;
		}

		static void n_SetEventId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EventId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()J", "GetGetEventIdHandler")]
			get {
				const string __id = "getEventId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='setEventId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setEventId", "(J)V", "GetSetEventId_JHandler")]
			set {
				const string __id = "setEventId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEventTag;
#pragma warning disable 0169
		static Delegate GetGetEventTagHandler ()
		{
			if (cb_getEventTag == null)
				cb_getEventTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEventTag);
			return cb_getEventTag;
		}

		static IntPtr n_GetEventTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventTag);
		}
#pragma warning restore 0169

		static Delegate cb_setEventTag_Lcom_vivalnk_sdk_model_Event_Tag_;
#pragma warning disable 0169
		static Delegate GetSetEventTag_Lcom_vivalnk_sdk_model_Event_Tag_Handler ()
		{
			if (cb_setEventTag_Lcom_vivalnk_sdk_model_Event_Tag_ == null)
				cb_setEventTag_Lcom_vivalnk_sdk_model_Event_Tag_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEventTag_Lcom_vivalnk_sdk_model_Event_Tag_);
			return cb_setEventTag_Lcom_vivalnk_sdk_model_Event_Tag_;
		}

		static void n_SetEventTag_Lcom_vivalnk_sdk_model_Event_Tag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EventTag = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Event.Tag EventTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getEventTag' and count(parameter)=0]"
			[Register ("getEventTag", "()Lcom/vivalnk/sdk/model/Event$Tag;", "GetGetEventTagHandler")]
			get {
				const string __id = "getEventTag.()Lcom/vivalnk/sdk/model/Event$Tag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='setEventTag' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Event.Tag']]"
			[Register ("setEventTag", "(Lcom/vivalnk/sdk/model/Event$Tag;)V", "GetSetEventTag_Lcom_vivalnk_sdk_model_Event_Tag_Handler")]
			set {
				const string __id = "setEventTag.(Lcom/vivalnk/sdk/model/Event$Tag;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/lang/Long;", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addData_Lcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAddData_Lcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_addData_Lcom_vivalnk_sdk_model_SampleData_ == null)
				cb_addData_Lcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddData_Lcom_vivalnk_sdk_model_SampleData_);
			return cb_addData_Lcom_vivalnk_sdk_model_SampleData_;
		}

		static void n_AddData_Lcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='addData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("addData", "(Lcom/vivalnk/sdk/model/SampleData;)V", "GetAddData_Lcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe void AddData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			const string __id = "addData.(Lcom/vivalnk/sdk/model/SampleData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEventType;
#pragma warning disable 0169
		static Delegate GetGetEventTypeHandler ()
		{
			if (cb_getEventType == null)
				cb_getEventType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEventType);
			return cb_getEventType;
		}

		static IntPtr n_GetEventType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetEventType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='Event']/method[@name='getEventType' and count(parameter)=0]"
		[Register ("getEventType", "()Lcom/vivalnk/sdk/model/Event$EventType;", "GetGetEventTypeHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Event.EventType GetEventType ()
		{
			const string __id = "getEventType.()Lcom/vivalnk/sdk/model/Event$EventType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
