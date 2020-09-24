using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/Motion", DoNotGenerateAcw=true)]
	public partial class Motion : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/field[@name='x']"
		[Register ("x")]
		public int X {
			get {
				const string __id = "x.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "x.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/field[@name='y']"
		[Register ("y")]
		public int Y {
			get {
				const string __id = "y.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "y.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/field[@name='z']"
		[Register ("z")]
		public int Z {
			get {
				const string __id = "z.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "z.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/Motion", typeof (Motion));
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

		protected Motion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/constructor[@name='Motion' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe Motion (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetX);
			return cb_getX;
		}

		static int n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.Motion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()I", "GetGetXHandler")]
		public virtual unsafe int GetX ()
		{
			const string __id = "getX.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetY);
			return cb_getY;
		}

		static int n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.Motion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()I", "GetGetYHandler")]
		public virtual unsafe int GetY ()
		{
			const string __id = "getY.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getZ;
#pragma warning disable 0169
		static Delegate GetGetZHandler ()
		{
			if (cb_getZ == null)
				cb_getZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetZ);
			return cb_getZ;
		}

		static int n_GetZ (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Vital.Ete.Motion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetZ ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='Motion']/method[@name='getZ' and count(parameter)=0]"
		[Register ("getZ", "()I", "GetGetZHandler")]
		public virtual unsafe int GetZ ()
		{
			const string __id = "getZ.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
