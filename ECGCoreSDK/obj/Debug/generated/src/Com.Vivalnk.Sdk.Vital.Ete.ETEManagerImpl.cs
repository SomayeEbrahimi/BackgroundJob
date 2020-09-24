using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEManagerImpl", DoNotGenerateAcw=true)]
	public partial class ETEManagerImpl : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Vital.Ete.IETEOperation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "ETEManagerImpl";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='a']"
		[Register ("a")]
		public global::FI.Firstbeat.Ete.ETE A {
			get {
				const string __id = "a.Lfi/firstbeat/ete/ETE;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lfi/firstbeat/ete/ETE;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='b']"
		[Register ("b")]
		public global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener B {
			get {
				const string __id = "b.Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='c']"
		[Register ("c")]
		public long C {
			get {
				const string __id = "c.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "c.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='d']"
		[Register ("d")]
		public long D {
			get {
				const string __id = "d.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "d.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='e']"
		[Register ("e")]
		public long E {
			get {
				const string __id = "e.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "e.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='f']"
		[Register ("f")]
		public int F {
			get {
				const string __id = "f.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "f.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='g']"
		[Register ("g")]
		public float G {
			get {
				const string __id = "g.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "g.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='h']"
		[Register ("h")]
		public long H {
			get {
				const string __id = "h.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "h.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='i']"
		[Register ("i")]
		public global::System.Collections.IList I {
			get {
				const string __id = "i.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "i.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='j']"
		[Register ("j")]
		public global::System.Collections.IList J {
			get {
				const string __id = "j.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "j.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='k']"
		[Register ("k")]
		public global::System.Collections.IList K {
			get {
				const string __id = "k.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "k.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='l']"
		[Register ("l")]
		public global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter L {
			get {
				const string __id = "l.Lcom/vivalnk/sdk/vital/ete/ETEParameter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "l.Lcom/vivalnk/sdk/vital/ete/ETEParameter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='m']"
		[Register ("m")]
		public const bool M = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/field[@name='n']"
		[Register ("n")]
		public const int N = (int) 5;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEManagerImpl$FBInputData", DoNotGenerateAcw=true)]
		public partial class FBInputData : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='accList']"
			[Register ("accList")]
			public IList<Com.Vivalnk.Sdk.Vital.Ete.Motion> AccList {
				get {
					const string __id = "accList.[Lcom/vivalnk/sdk/vital/ete/Motion;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Vital.Ete.Motion>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "accList.[Lcom/vivalnk/sdk/vital/ete/Motion;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Vital.Ete.Motion>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='flash']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='instanceId']"
			[Register ("instanceId")]
			public long InstanceId {
				get {
					const string __id = "instanceId.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "instanceId.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='lastMill']"
			[Register ("lastMill")]
			public long LastMill {
				get {
					const string __id = "lastMill.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "lastMill.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='leadOn']"
			[Register ("leadOn")]
			public bool LeadOn {
				get {
					const string __id = "leadOn.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "leadOn.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='rriList']"
			[Register ("rriList")]
			public IList<int> RriList {
				get {
					const string __id = "rriList.[I";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rriList.[I";

					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/field[@name='time']"
			[Register ("time")]
			public long Time {
				get {
					const string __id = "time.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "time.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEManagerImpl$FBInputData", typeof (FBInputData));
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

			protected FBInputData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBInputData']/constructor[@name='ETEManagerImpl.FBInputData' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int[]'] and parameter[5][@type='com.vivalnk.sdk.vital.ete.Motion[]'] and parameter[6][@type='boolean'] and parameter[7][@type='long']]"
			[Register (".ctor", "(JZJ[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZJ)V", "")]
			public unsafe FBInputData (long p0, bool p1, long p2, int[] p3, global::Com.Vivalnk.Sdk.Vital.Ete.Motion[] p4, bool p5, long p6)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JZJ[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZJ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					__args [3] = new JniArgumentValue (native_p3);
					__args [4] = new JniArgumentValue (native_p4);
					__args [5] = new JniArgumentValue (p5);
					__args [6] = new JniArgumentValue (p6);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBOutData']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEManagerImpl$FBOutData", DoNotGenerateAcw=true)]
		public partial class FBOutData : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBOutData']/field[@name='eteResult']"
			[Register ("eteResult")]
			public global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult EteResult {
				get {
					const string __id = "eteResult.Lcom/vivalnk/sdk/vital/ete/ETEResult;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "eteResult.Lcom/vivalnk/sdk/vital/ete/ETEResult;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBOutData']/field[@name='flash']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBOutData']/field[@name='instanceId']"
			[Register ("instanceId")]
			public long InstanceId {
				get {
					const string __id = "instanceId.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "instanceId.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEManagerImpl$FBOutData", typeof (FBOutData));
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

			protected FBOutData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl.FBOutData']/constructor[@name='ETEManagerImpl.FBOutData' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='com.vivalnk.sdk.vital.ete.ETEResult']]"
			[Register (".ctor", "(JZLcom/vivalnk/sdk/vital/ete/ETEResult;)V", "")]
			public unsafe FBOutData (long p0, bool p1, global::Com.Vivalnk.Sdk.Vital.Ete.ETEResult p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(JZLcom/vivalnk/sdk/vital/ete/ETEResult;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEManagerImpl", typeof (ETEManagerImpl));
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

		protected ETEManagerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/constructor[@name='ETEManagerImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ETEManagerImpl ()
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

		static Delegate cb_getETEResultSync;
#pragma warning disable 0169
		static Delegate GetGetETEResultSyncHandler ()
		{
			if (cb_getETEResultSync == null)
				cb_getETEResultSync = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetETEResultSync);
			return cb_getETEResultSync;
		}

		static IntPtr n_GetETEResultSync (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ETEResultSync);
		}
#pragma warning restore 0169

		public virtual unsafe global::FI.Firstbeat.Ete.ETEresults ETEResultSync {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='getETEResultSync' and count(parameter)=0]"
			[Register ("getETEResultSync", "()Lfi/firstbeat/ete/ETEresults;", "GetGetETEResultSyncHandler")]
			get {
				const string __id = "getETEResultSync.()Lfi/firstbeat/ete/ETEresults;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETEresults> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getETEVersion;
#pragma warning disable 0169
		static Delegate GetGetETEVersionHandler ()
		{
			if (cb_getETEVersion == null)
				cb_getETEVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetETEVersion);
			return cb_getETEVersion;
		}

		static IntPtr n_GetETEVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETEVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string ETEVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='getETEVersion' and count(parameter)=0]"
			[Register ("getETEVersion", "()Ljava/lang/String;", "GetGetETEVersionHandler")]
			get {
				const string __id = "getETEVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAnalyzerData_Lcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ == null)
				cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AnalyzerData_Lcom_vivalnk_sdk_model_SampleData_);
			return cb_analyzerData_Lcom_vivalnk_sdk_model_SampleData_;
		}

		static int n_AnalyzerData_Lcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AnalyzerData (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='analyzerData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("analyzerData", "(Lcom/vivalnk/sdk/model/SampleData;)I", "GetAnalyzerData_Lcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe int AnalyzerData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			const string __id = "analyzerData.(Lcom/vivalnk/sdk/model/SampleData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ;
#pragma warning disable 0169
		static Delegate GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZHandler ()
		{
			if (cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ == null)
				cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJLLZZ_I) n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ);
			return cb_analyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ;
		}

		static int n_AnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (global::Com.Vivalnk.Sdk.Vital.Ete.Motion[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Vital.Ete.Motion));
			int __ret = __this.AnalyzerData (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='analyzerData' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int[]'] and parameter[3][@type='com.vivalnk.sdk.vital.ete.Motion[]'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("analyzerData", "(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZZ)I", "GetAnalyzerData_JarrayIarrayLcom_vivalnk_sdk_vital_ete_Motion_ZZHandler")]
		public virtual unsafe int AnalyzerData (long p0, int[] p1, global::Com.Vivalnk.Sdk.Vital.Ete.Motion[] p2, bool p3, bool p4)
		{
			const string __id = "analyzerData.(J[I[Lcom/vivalnk/sdk/vital/ete/Motion;ZZ)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_checkETEResult_ZJ;
#pragma warning disable 0169
		static Delegate GetCheckETEResult_ZJHandler ()
		{
			if (cb_checkETEResult_ZJ == null)
				cb_checkETEResult_ZJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZJ_V) n_CheckETEResult_ZJ);
			return cb_checkETEResult_ZJ;
		}

		static void n_CheckETEResult_ZJ (IntPtr jnienv, IntPtr native__this, bool p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckETEResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='checkETEResult' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register ("checkETEResult", "(ZJ)V", "GetCheckETEResult_ZJHandler")]
		public virtual unsafe void CheckETEResult (bool p0, long p1)
		{
			const string __id = "checkETEResult.(ZJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_;
#pragma warning disable 0169
		static Delegate GetRegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_Handler ()
		{
			if (cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ == null)
				cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_);
			return cb_registerETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_;
		}

		static void n_RegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterETEDataReceiveListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='registerETEDataReceiveListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEDataReceiveListener']]"
		[Register ("registerETEDataReceiveListener", "(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V", "GetRegisterETEDataReceiveListener_Lcom_vivalnk_sdk_vital_ete_ETEDataReceiveListener_Handler")]
		public virtual unsafe void RegisterETEDataReceiveListener (global::Com.Vivalnk.Sdk.Vital.Ete.IETEDataReceiveListener p0)
		{
			const string __id = "registerETEDataReceiveListener.(Lcom/vivalnk/sdk/vital/ete/ETEDataReceiveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_;
#pragma warning disable 0169
		static Delegate GetSetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_Handler ()
		{
			if (cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ == null)
				cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_);
			return cb_setETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_;
		}

		static int n_SetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetETEParameters (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='setETEParameters' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.vital.ete.ETEParameter']]"
		[Register ("setETEParameters", "(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I", "GetSetETEParameters_Lcom_vivalnk_sdk_vital_ete_ETEParameter_Handler")]
		public virtual unsafe int SetETEParameters (global::Com.Vivalnk.Sdk.Vital.Ete.ETEParameter p0)
		{
			const string __id = "setETEParameters.(Lcom/vivalnk/sdk/vital/ete/ETEParameter;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unregisterETEDataReceiveListener;
#pragma warning disable 0169
		static Delegate GetUnregisterETEDataReceiveListenerHandler ()
		{
			if (cb_unregisterETEDataReceiveListener == null)
				cb_unregisterETEDataReceiveListener = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnregisterETEDataReceiveListener);
			return cb_unregisterETEDataReceiveListener;
		}

		static void n_UnregisterETEDataReceiveListener (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.ETEManagerImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterETEDataReceiveListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEManagerImpl']/method[@name='unregisterETEDataReceiveListener' and count(parameter)=0]"
		[Register ("unregisterETEDataReceiveListener", "()V", "GetUnregisterETEDataReceiveListenerHandler")]
		public virtual unsafe void UnregisterETEDataReceiveListener ()
		{
			const string __id = "unregisterETEDataReceiveListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
