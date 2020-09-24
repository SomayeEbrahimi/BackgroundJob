using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometerL']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleThermometerL", DoNotGenerateAcw=true)]
	public partial class VDIBleThermometerL : global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireaderimpl/VDIBleThermometerL", typeof (VDIBleThermometerL));
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

		protected VDIBleThermometerL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometerL']/constructor[@name='VDIBleThermometerL' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VDIBleThermometerL (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometerL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometerL']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometerL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometerL']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometerL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanFilter>.ToLocalJniHandle (__this.D ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometerL']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/util/List;", "GetDHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.LE.ScanFilter> D ()
		{
			const string __id = "d.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanFilter>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
