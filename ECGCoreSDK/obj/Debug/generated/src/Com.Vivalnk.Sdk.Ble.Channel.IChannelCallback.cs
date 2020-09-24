using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Ble.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.ble.channel']/interface[@name='ChannelCallback']"
	[Register ("com/vivalnk/sdk/ble/channel/ChannelCallback", "", "Com.Vivalnk.Sdk.Ble.Channel.IChannelCallbackInvoker")]
	public partial interface IChannelCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.channel']/interface[@name='ChannelCallback']/method[@name='onCharacterWriteComplete' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onCharacterWriteComplete", "([B)V", "GetOnCharacterWriteComplete_arrayBHandler:Com.Vivalnk.Sdk.Ble.Channel.IChannelCallbackInvoker, ECGCoreSDK")]
		void OnCharacterWriteComplete (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.channel']/interface[@name='ChannelCallback']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onComplete", "([B)V", "GetOnComplete_arrayBHandler:Com.Vivalnk.Sdk.Ble.Channel.IChannelCallbackInvoker, ECGCoreSDK")]
		void OnComplete (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.channel']/interface[@name='ChannelCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler:Com.Vivalnk.Sdk.Ble.Channel.IChannelCallbackInvoker, ECGCoreSDK")]
		void OnError (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.ble.channel']/interface[@name='ChannelCallback']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler:Com.Vivalnk.Sdk.Ble.Channel.IChannelCallbackInvoker, ECGCoreSDK")]
		void OnStart ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/ble/channel/ChannelCallback", DoNotGenerateAcw=true)]
	internal partial class IChannelCallbackInvoker : global::Java.Lang.Object, IChannelCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/ble/channel/ChannelCallback", typeof (IChannelCallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IChannelCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChannelCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.ble.channel.ChannelCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChannelCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCharacterWriteComplete_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCharacterWriteComplete_arrayBHandler ()
		{
			if (cb_onCharacterWriteComplete_arrayB == null)
				cb_onCharacterWriteComplete_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCharacterWriteComplete_arrayB);
			return cb_onCharacterWriteComplete_arrayB;
		}

		static void n_OnCharacterWriteComplete_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Channel.IChannelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCharacterWriteComplete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onCharacterWriteComplete_arrayB;
		public unsafe void OnCharacterWriteComplete (byte[] p0)
		{
			if (id_onCharacterWriteComplete_arrayB == IntPtr.Zero)
				id_onCharacterWriteComplete_arrayB = JNIEnv.GetMethodID (class_ref, "onCharacterWriteComplete", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCharacterWriteComplete_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onComplete_arrayB;
#pragma warning disable 0169
		static Delegate GetOnComplete_arrayBHandler ()
		{
			if (cb_onComplete_arrayB == null)
				cb_onComplete_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnComplete_arrayB);
			return cb_onComplete_arrayB;
		}

		static void n_OnComplete_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Channel.IChannelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnComplete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_arrayB;
		public unsafe void OnComplete (byte[] p0)
		{
			if (id_onComplete_arrayB == IntPtr.Zero)
				id_onComplete_arrayB = JNIEnv.GetMethodID (class_ref, "onComplete", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Handler ()
		{
			if (cb_onError_ILjava_lang_String_ == null)
				cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnError_ILjava_lang_String_);
			return cb_onError_ILjava_lang_String_;
		}

		static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Channel.IChannelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_ILjava_lang_String_;
		public unsafe void OnError (int p0, string p1)
		{
			if (id_onError_ILjava_lang_String_ == IntPtr.Zero)
				id_onError_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Ble.Channel.IChannelCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		IntPtr id_onStart;
		public unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart);
		}

	}

}
