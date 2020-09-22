using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Mutable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/mutable/MutableBoolean", DoNotGenerateAcw=true)]
	public partial class MutableBoolean : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/mutable/MutableBoolean", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MutableBoolean); }
		}

		protected MutableBoolean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/constructor[@name='MutableBoolean' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableBoolean ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MutableBoolean)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/constructor[@name='MutableBoolean' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe MutableBoolean (bool value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableBoolean)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Boolean_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/constructor[@name='MutableBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register (".ctor", "(Ljava/lang/Boolean;)V", "")]
		public unsafe MutableBoolean (global::Java.Lang.Boolean value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableBoolean)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Boolean;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Boolean;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Boolean;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Boolean_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Boolean_, __args);
			} finally {
			}
		}

		static Delegate cb_isFalse;
#pragma warning disable 0169
		static Delegate GetIsFalseHandler ()
		{
			if (cb_isFalse == null)
				cb_isFalse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFalse);
			return cb_isFalse;
		}

		static bool n_IsFalse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFalse;
		}
#pragma warning restore 0169

		static IntPtr id_isFalse;
		public virtual unsafe bool IsFalse {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='isFalse' and count(parameter)=0]"
			[Register ("isFalse", "()Z", "GetIsFalseHandler")]
			get {
				if (id_isFalse == IntPtr.Zero)
					id_isFalse = JNIEnv.GetMethodID (class_ref, "isFalse", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFalse);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFalse", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTrue;
#pragma warning disable 0169
		static Delegate GetIsTrueHandler ()
		{
			if (cb_isTrue == null)
				cb_isTrue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTrue);
			return cb_isTrue;
		}

		static bool n_IsTrue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTrue;
		}
#pragma warning restore 0169

		static IntPtr id_isTrue;
		public virtual unsafe bool IsTrue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='isTrue' and count(parameter)=0]"
			[Register ("isTrue", "()Z", "GetIsTrueHandler")]
			get {
				if (id_isTrue == IntPtr.Zero)
					id_isTrue = JNIEnv.GetMethodID (class_ref, "isTrue", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTrue);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTrue", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setValue_Ljava_lang_Boolean_ == null)
				cb_setValue_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_Boolean_);
			return cb_setValue_Ljava_lang_Boolean_;
		}

		static void n_SetValue_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Boolean;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setValue", "(Ljava/lang/Boolean;)V", "GetSetValue_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setValue_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setValue_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_booleanValue;
#pragma warning disable 0169
		static Delegate GetBooleanValueHandler ()
		{
			if (cb_booleanValue == null)
				cb_booleanValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_BooleanValue);
			return cb_booleanValue;
		}

		static bool n_BooleanValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BooleanValue ();
		}
#pragma warning restore 0169

		static IntPtr id_booleanValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='booleanValue' and count(parameter)=0]"
		[Register ("booleanValue", "()Z", "GetBooleanValueHandler")]
		public virtual unsafe bool BooleanValue ()
		{
			if (id_booleanValue == IntPtr.Zero)
				id_booleanValue = JNIEnv.GetMethodID (class_ref, "booleanValue", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_booleanValue);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "booleanValue", "()Z"));
			} finally {
			}
		}

		static Delegate cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_Handler ()
		{
			if (cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_ == null)
				cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_);
			return cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_;
		}

		static int n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.mutable.MutableBoolean']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/mutable/MutableBoolean;)I", "GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_Handler")]
		public virtual unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableBoolean;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_mutable_MutableBoolean_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableBoolean;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setFalse;
#pragma warning disable 0169
		static Delegate GetSetFalseHandler ()
		{
			if (cb_setFalse == null)
				cb_setFalse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetFalse);
			return cb_setFalse;
		}

		static void n_SetFalse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFalse ();
		}
#pragma warning restore 0169

		static IntPtr id_setFalse;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='setFalse' and count(parameter)=0]"
		[Register ("setFalse", "()V", "GetSetFalseHandler")]
		public virtual unsafe void SetFalse ()
		{
			if (id_setFalse == IntPtr.Zero)
				id_setFalse = JNIEnv.GetMethodID (class_ref, "setFalse", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFalse);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFalse", "()V"));
			} finally {
			}
		}

		static Delegate cb_setTrue;
#pragma warning disable 0169
		static Delegate GetSetTrueHandler ()
		{
			if (cb_setTrue == null)
				cb_setTrue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetTrue);
			return cb_setTrue;
		}

		static void n_SetTrue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrue ();
		}
#pragma warning restore 0169

		static IntPtr id_setTrue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='setTrue' and count(parameter)=0]"
		[Register ("setTrue", "()V", "GetSetTrueHandler")]
		public virtual unsafe void SetTrue ()
		{
			if (id_setTrue == IntPtr.Zero)
				id_setTrue = JNIEnv.GetMethodID (class_ref, "setTrue", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrue);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrue", "()V"));
			} finally {
			}
		}

		static Delegate cb_setValue_Z;
#pragma warning disable 0169
		static Delegate GetSetValue_ZHandler ()
		{
			if (cb_setValue_Z == null)
				cb_setValue_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetValue_Z);
			return cb_setValue_Z;
		}

		static void n_SetValue_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setValue", "(Z)V", "GetSetValue_ZHandler")]
		public virtual unsafe void SetValue (bool value)
		{
			if (id_setValue_Z == IntPtr.Zero)
				id_setValue_Z = JNIEnv.GetMethodID (class_ref, "setValue", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toBoolean;
#pragma warning disable 0169
		static Delegate GetToBooleanHandler ()
		{
			if (cb_toBoolean == null)
				cb_toBoolean = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToBoolean);
			return cb_toBoolean;
		}

		static IntPtr n_ToBoolean (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableBoolean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBoolean ());
		}
#pragma warning restore 0169

		static IntPtr id_toBoolean;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableBoolean']/method[@name='toBoolean' and count(parameter)=0]"
		[Register ("toBoolean", "()Ljava/lang/Boolean;", "GetToBooleanHandler")]
		public virtual unsafe global::Java.Lang.Boolean ToBoolean ()
		{
			if (id_toBoolean == IntPtr.Zero)
				id_toBoolean = JNIEnv.GetMethodID (class_ref, "toBoolean", "()Ljava/lang/Boolean;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBoolean), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBoolean", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Mutable.IMutable
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Mutable.IMutable.Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] get {
				return Value;
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] set {
				Value = global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Boolean>(value);
			}
		}

	}
}
