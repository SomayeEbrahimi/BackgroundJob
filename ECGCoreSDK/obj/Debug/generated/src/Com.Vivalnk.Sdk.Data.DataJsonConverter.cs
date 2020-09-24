using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/data/DataJsonConverter", DoNotGenerateAcw=true)]
	public partial class DataJsonConverter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/data/DataJsonConverter$DataEvent", DoNotGenerateAcw=true)]
		public partial class DataEvent : global::Java.Lang.Object, global::Java.IO.ISerializable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='deviceId']"
			[Register ("deviceId")]
			public string DeviceId {
				get {
					const string __id = "deviceId.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceId.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='deviceName']"
			[Register ("deviceName")]
			public string DeviceName {
				get {
					const string __id = "deviceName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='endTime']"
			[Register ("endTime")]
			public long EndTime {
				get {
					const string __id = "endTime.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "endTime.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='eventId']"
			[Register ("eventId")]
			public long EventId {
				get {
					const string __id = "eventId.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "eventId.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='eventTag']"
			[Register ("eventTag")]
			public global::Com.Vivalnk.Sdk.Model.Event.Tag EventTag {
				get {
					const string __id = "eventTag.Lcom/vivalnk/sdk/model/Event$Tag;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.Tag> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "eventTag.Lcom/vivalnk/sdk/model/Event$Tag;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='eventType']"
			[Register ("eventType")]
			public global::Com.Vivalnk.Sdk.Model.Event.EventType EventType {
				get {
					const string __id = "eventType.Lcom/vivalnk/sdk/model/Event$EventType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event.EventType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "eventType.Lcom/vivalnk/sdk/model/Event$EventType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='flash']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/field[@name='startTime']"
			[Register ("startTime")]
			public long StartTime {
				get {
					const string __id = "startTime.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "startTime.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/DataJsonConverter$DataEvent", typeof (DataEvent));
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

			protected DataEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataEvent']/constructor[@name='DataJsonConverter.DataEvent' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Event']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/model/Event;)V", "")]
			public unsafe DataEvent (global::Com.Vivalnk.Sdk.Model.Event p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/vivalnk/sdk/model/Event;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/data/DataJsonConverter$DataFormated", DoNotGenerateAcw=true)]
		public partial class DataFormated : global::Java.Lang.Object, global::Java.IO.ISerializable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='BP']"
			[Register ("BP")]
			public string Bp {
				get {
					const string __id = "BP.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "BP.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='HR']"
			[Register ("HR")]
			public global::Java.Lang.Integer Hr {
				get {
					const string __id = "HR.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "HR.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='RR']"
			[Register ("RR")]
			public global::Java.Lang.Float Rr {
				get {
					const string __id = "RR.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "RR.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='acc']"
			[Register ("acc")]
			public IList<Com.Vivalnk.Sdk.Model.Motion> Acc {
				get {
					const string __id = "acc.[Lcom/vivalnk/sdk/model/Motion;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Model.Motion>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "acc.[Lcom/vivalnk/sdk/model/Motion;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Model.Motion>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='accAccuracy']"
			[Register ("accAccuracy")]
			public global::Java.Lang.Integer AccAccuracy {
				get {
					const string __id = "accAccuracy.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accAccuracy.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='accFrequency']"
			[Register ("accFrequency")]
			public global::Java.Lang.Integer AccFrequency {
				get {
					const string __id = "accFrequency.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accFrequency.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='activity']"
			[Register ("activity")]
			public global::Java.Lang.Boolean Activity {
				get {
					const string __id = "activity.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "activity.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='avRR']"
			[Register ("avRR")]
			public global::Java.Lang.Float AvRR {
				get {
					const string __id = "avRR.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "avRR.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='deviceID']"
			[Register ("deviceID")]
			public string DeviceID {
				get {
					const string __id = "deviceID.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceID.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='deviceModel']"
			[Register ("deviceModel")]
			public global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
				get {
					const string __id = "deviceModel.Lcom/vivalnk/sdk/model/DeviceModel;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceModel.Lcom/vivalnk/sdk/model/DeviceModel;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='deviceName']"
			[Register ("deviceName")]
			public string DeviceName {
				get {
					const string __id = "deviceName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='deviceSN']"
			[Register ("deviceSN")]
			public string DeviceSN {
				get {
					const string __id = "deviceSN.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceSN.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='ecg']"
			[Register ("ecg")]
			public IList<int> Ecg {
				get {
					const string __id = "ecg.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ecg.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='ecgFrequency']"
			[Register ("ecgFrequency")]
			public global::Java.Lang.Integer EcgFrequency {
				get {
					const string __id = "ecgFrequency.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ecgFrequency.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='flash']"
			[Register ("flash")]
			public global::Java.Lang.Boolean Flash {
				get {
					const string __id = "flash.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "flash.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='id']"
			[Register ("id")]
			public long Id {
				get {
					const string __id = "id.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "id.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='leadOn']"
			[Register ("leadOn")]
			public global::Java.Lang.Boolean LeadOn {
				get {
					const string __id = "leadOn.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "leadOn.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='magnification']"
			[Register ("magnification")]
			public global::Java.Lang.Integer Magnification {
				get {
					const string __id = "magnification.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "magnification.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='receiveTime']"
			[Register ("receiveTime")]
			public global::Java.Lang.Long ReceiveTime {
				get {
					const string __id = "receiveTime.Ljava/lang/Long;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "receiveTime.Ljava/lang/Long;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='rri']"
			[Register ("rri")]
			public IList<int> Rri {
				get {
					const string __id = "rri.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rri.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='rwl']"
			[Register ("rwl")]
			public IList<int> Rwl {
				get {
					const string __id = "rwl.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rwl.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='temperature']"
			[Register ("temperature")]
			public global::Java.Lang.Float Temperature {
				get {
					const string __id = "temperature.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "temperature.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/field[@name='time']"
			[Register ("time")]
			public global::Java.Lang.Long Time {
				get {
					const string __id = "time.Ljava/lang/Long;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "time.Ljava/lang/Long;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/DataJsonConverter$DataFormated", typeof (DataFormated));
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

			protected DataFormated (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormated']/constructor[@name='DataJsonConverter.DataFormated' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DataFormated ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet", DoNotGenerateAcw=true)]
		public partial class DataFormatedNet : global::Java.Lang.Object, global::Java.IO.ISerializable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='BP']"
			[Register ("BP")]
			public string Bp {
				get {
					const string __id = "BP.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "BP.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='HR']"
			[Register ("HR")]
			public global::Java.Lang.Integer Hr {
				get {
					const string __id = "HR.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "HR.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='RR']"
			[Register ("RR")]
			public global::Java.Lang.Float Rr {
				get {
					const string __id = "RR.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "RR.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='acc']"
			[Register ("acc")]
			public IList<Com.Vivalnk.Sdk.Model.Motion> Acc {
				get {
					const string __id = "acc.[Lcom/vivalnk/sdk/model/Motion;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Model.Motion>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "acc.[Lcom/vivalnk/sdk/model/Motion;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Model.Motion>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='accAccuracy']"
			[Register ("accAccuracy")]
			public global::Java.Lang.Integer AccAccuracy {
				get {
					const string __id = "accAccuracy.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accAccuracy.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='accFrequency']"
			[Register ("accFrequency")]
			public global::Java.Lang.Integer AccFrequency {
				get {
					const string __id = "accFrequency.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accFrequency.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='activity']"
			[Register ("activity")]
			public global::Java.Lang.Boolean Activity {
				get {
					const string __id = "activity.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "activity.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='avRR']"
			[Register ("avRR")]
			public global::Java.Lang.Float AvRR {
				get {
					const string __id = "avRR.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "avRR.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='deviceID']"
			[Register ("deviceID")]
			public string DeviceID {
				get {
					const string __id = "deviceID.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceID.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='deviceModel']"
			[Register ("deviceModel")]
			public global::Com.Vivalnk.Sdk.Model.DeviceModel DeviceModel {
				get {
					const string __id = "deviceModel.Lcom/vivalnk/sdk/model/DeviceModel;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceModel.Lcom/vivalnk/sdk/model/DeviceModel;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='deviceName']"
			[Register ("deviceName")]
			public string DeviceName {
				get {
					const string __id = "deviceName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='deviceSN']"
			[Register ("deviceSN")]
			public string DeviceSN {
				get {
					const string __id = "deviceSN.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "deviceSN.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='ecg']"
			[Register ("ecg")]
			public IList<int> Ecg {
				get {
					const string __id = "ecg.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ecg.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='ecgFrequency']"
			[Register ("ecgFrequency")]
			public global::Java.Lang.Integer EcgFrequency {
				get {
					const string __id = "ecgFrequency.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ecgFrequency.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='flash']"
			[Register ("flash")]
			public global::Java.Lang.Boolean Flash {
				get {
					const string __id = "flash.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "flash.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='leadOn']"
			[Register ("leadOn")]
			public global::Java.Lang.Boolean LeadOn {
				get {
					const string __id = "leadOn.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "leadOn.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='magnification']"
			[Register ("magnification")]
			public global::Java.Lang.Integer Magnification {
				get {
					const string __id = "magnification.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "magnification.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='receiveTime']"
			[Register ("receiveTime")]
			public global::Java.Lang.Long ReceiveTime {
				get {
					const string __id = "receiveTime.Ljava/lang/Long;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "receiveTime.Ljava/lang/Long;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='rri']"
			[Register ("rri")]
			public IList<int> Rri {
				get {
					const string __id = "rri.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rri.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='rwl']"
			[Register ("rwl")]
			public IList<int> Rwl {
				get {
					const string __id = "rwl.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rwl.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='temperature']"
			[Register ("temperature")]
			public global::Java.Lang.Float Temperature {
				get {
					const string __id = "temperature.Ljava/lang/Float;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "temperature.Ljava/lang/Float;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/field[@name='time']"
			[Register ("time")]
			public global::Java.Lang.Long Time {
				get {
					const string __id = "time.Ljava/lang/Long;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "time.Ljava/lang/Long;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet", typeof (DataFormatedNet));
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

			protected DataFormatedNet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/constructor[@name='DataJsonConverter.DataFormatedNet' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "")]
			public unsafe DataFormatedNet (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/vivalnk/sdk/repository/local/database/VitalData;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_convertToVitalData;
#pragma warning disable 0169
			static Delegate GetConvertToVitalDataHandler ()
			{
				if (cb_convertToVitalData == null)
					cb_convertToVitalData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ConvertToVitalData);
				return cb_convertToVitalData;
			}

			static IntPtr n_ConvertToVitalData (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormatedNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ConvertToVitalData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter.DataFormatedNet']/method[@name='convertToVitalData' and count(parameter)=0]"
			[Register ("convertToVitalData", "()Lcom/vivalnk/sdk/repository/local/database/VitalData;", "GetConvertToVitalDataHandler")]
			public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData ConvertToVitalData ()
			{
				const string __id = "convertToVitalData.()Lcom/vivalnk/sdk/repository/local/database/VitalData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/DataJsonConverter", typeof (DataJsonConverter));
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

		protected DataJsonConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter']/constructor[@name='DataJsonConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataJsonConverter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated FromJson (string p0)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter']/method[@name='toFullJson' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.data.DataJsonConverter.DataFormated']]"
		[Register ("toFullJson", "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)Ljava/lang/String;", "")]
		public static unsafe string ToFullJson (global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated p0)
		{
			const string __id = "toFullJson.(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data']/class[@name='DataJsonConverter']/method[@name='toSimpleJson' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.data.DataJsonConverter.DataFormated']]"
		[Register ("toSimpleJson", "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)Ljava/lang/String;", "")]
		public static unsafe string ToSimpleJson (global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormated p0)
		{
			const string __id = "toSimpleJson.(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormated;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
