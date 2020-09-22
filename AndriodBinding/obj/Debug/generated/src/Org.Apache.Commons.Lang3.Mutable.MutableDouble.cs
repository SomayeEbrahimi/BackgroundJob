using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Mutable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/mutable/MutableDouble", DoNotGenerateAcw=true)]
	public partial class MutableDouble : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/mutable/MutableDouble", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MutableDouble); }
		}

		protected MutableDouble (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/constructor[@name='MutableDouble' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableDouble ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MutableDouble)) {
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

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/constructor[@name='MutableDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe MutableDouble (double value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableDouble)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Number_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/constructor[@name='MutableDouble' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/Number;)V", "")]
		public unsafe MutableDouble (global::Java.Lang.Number value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableDouble)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Number;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Number;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Number_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Number;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Number_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Number_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/constructor[@name='MutableDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MutableDouble (string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				if (((object) this).GetType () != typeof (MutableDouble)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAndDecrement;
#pragma warning disable 0169
		static Delegate GetGetAndDecrementHandler ()
		{
			if (cb_getAndDecrement == null)
				cb_getAndDecrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetAndDecrement);
			return cb_getAndDecrement;
		}

		static double n_GetAndDecrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndDecrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndDecrement;
		public virtual unsafe double AndDecrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='getAndDecrement' and count(parameter)=0]"
			[Register ("getAndDecrement", "()D", "GetGetAndDecrementHandler")]
			get {
				if (id_getAndDecrement == IntPtr.Zero)
					id_getAndDecrement = JNIEnv.GetMethodID (class_ref, "getAndDecrement", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAndDecrement);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndDecrement", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getAndIncrement;
#pragma warning disable 0169
		static Delegate GetGetAndIncrementHandler ()
		{
			if (cb_getAndIncrement == null)
				cb_getAndIncrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetAndIncrement);
			return cb_getAndIncrement;
		}

		static double n_GetAndIncrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndIncrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndIncrement;
		public virtual unsafe double AndIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='getAndIncrement' and count(parameter)=0]"
			[Register ("getAndIncrement", "()D", "GetGetAndIncrementHandler")]
			get {
				if (id_getAndIncrement == IntPtr.Zero)
					id_getAndIncrement = JNIEnv.GetMethodID (class_ref, "getAndIncrement", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAndIncrement);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndIncrement", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_isInfinite;
#pragma warning disable 0169
		static Delegate GetIsInfiniteHandler ()
		{
			if (cb_isInfinite == null)
				cb_isInfinite = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInfinite);
			return cb_isInfinite;
		}

		static bool n_IsInfinite (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfinite;
		}
#pragma warning restore 0169

		static IntPtr id_isInfinite;
		public virtual unsafe bool IsInfinite {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='isInfinite' and count(parameter)=0]"
			[Register ("isInfinite", "()Z", "GetIsInfiniteHandler")]
			get {
				if (id_isInfinite == IntPtr.Zero)
					id_isInfinite = JNIEnv.GetMethodID (class_ref, "isInfinite", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInfinite);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInfinite", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNaN;
#pragma warning disable 0169
		static Delegate GetIsNaNHandler ()
		{
			if (cb_isNaN == null)
				cb_isNaN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNaN);
			return cb_isNaN;
		}

		static bool n_IsNaN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNaN;
		}
#pragma warning restore 0169

		static IntPtr id_isNaN;
		public virtual unsafe bool IsNaN {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='isNaN' and count(parameter)=0]"
			[Register ("isNaN", "()Z", "GetIsNaNHandler")]
			get {
				if (id_isNaN == IntPtr.Zero)
					id_isNaN = JNIEnv.GetMethodID (class_ref, "isNaN", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNaN);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNaN", "()Z"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe global::Java.Lang.Double Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Double;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_D;
#pragma warning disable 0169
		static Delegate GetAdd_DHandler ()
		{
			if (cb_add_D == null)
				cb_add_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_Add_D);
			return cb_add_D;
		}

		static void n_Add_D (IntPtr jnienv, IntPtr native__this, double operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='add' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("add", "(D)V", "GetAdd_DHandler")]
		public virtual unsafe void Add (double operand)
		{
			if (id_add_D == IntPtr.Zero)
				id_add_D = JNIEnv.GetMethodID (class_ref, "add", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Number_Handler ()
		{
			if (cb_add_Ljava_lang_Number_ == null)
				cb_add_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Ljava_lang_Number_);
			return cb_add_Ljava_lang_Number_;
		}

		static void n_Add_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("add", "(Ljava/lang/Number;)V", "GetAdd_Ljava_lang_Number_Handler")]
		public virtual unsafe void Add (global::Java.Lang.Number operand)
		{
			if (id_add_Ljava_lang_Number_ == IntPtr.Zero)
				id_add_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addAndGet_D;
#pragma warning disable 0169
		static Delegate GetAddAndGet_DHandler ()
		{
			if (cb_addAndGet_D == null)
				cb_addAndGet_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_D) n_AddAndGet_D);
			return cb_addAndGet_D;
		}

		static double n_AddAndGet_D (IntPtr jnienv, IntPtr native__this, double operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AddAndGet (operand);
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("addAndGet", "(D)D", "GetAddAndGet_DHandler")]
		public virtual unsafe double AddAndGet (double operand)
		{
			if (id_addAndGet_D == IntPtr.Zero)
				id_addAndGet_D = JNIEnv.GetMethodID (class_ref, "addAndGet", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_D, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(D)D"), __args);
			} finally {
			}
		}

		static Delegate cb_addAndGet_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddAndGet_Ljava_lang_Number_Handler ()
		{
			if (cb_addAndGet_Ljava_lang_Number_ == null)
				cb_addAndGet_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_D) n_AddAndGet_Ljava_lang_Number_);
			return cb_addAndGet_Ljava_lang_Number_;
		}

		static double n_AddAndGet_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.AddAndGet (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("addAndGet", "(Ljava/lang/Number;)D", "GetAddAndGet_Ljava_lang_Number_Handler")]
		public virtual unsafe double AddAndGet (global::Java.Lang.Number operand)
		{
			if (id_addAndGet_Ljava_lang_Number_ == IntPtr.Zero)
				id_addAndGet_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addAndGet", "(Ljava/lang/Number;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				double __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(Ljava/lang/Number;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_Handler ()
		{
			if (cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_ == null)
				cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_);
			return cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_;
		}

		static int n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.mutable.MutableDouble']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/mutable/MutableDouble;)I", "GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_Handler")]
		public virtual unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Mutable.MutableDouble other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableDouble;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_mutable_MutableDouble_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableDouble;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decrement;
#pragma warning disable 0169
		static Delegate GetDecrementHandler ()
		{
			if (cb_decrement == null)
				cb_decrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Decrement);
			return cb_decrement;
		}

		static void n_Decrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement ();
		}
#pragma warning restore 0169

		static IntPtr id_decrement;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='decrement' and count(parameter)=0]"
		[Register ("decrement", "()V", "GetDecrementHandler")]
		public virtual unsafe void Decrement ()
		{
			if (id_decrement == IntPtr.Zero)
				id_decrement = JNIEnv.GetMethodID (class_ref, "decrement", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decrement);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrement", "()V"));
			} finally {
			}
		}

		static Delegate cb_decrementAndGet;
#pragma warning disable 0169
		static Delegate GetDecrementAndGetHandler ()
		{
			if (cb_decrementAndGet == null)
				cb_decrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_DecrementAndGet);
			return cb_decrementAndGet;
		}

		static double n_DecrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_decrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='decrementAndGet' and count(parameter)=0]"
		[Register ("decrementAndGet", "()D", "GetDecrementAndGetHandler")]
		public virtual unsafe double DecrementAndGet ()
		{
			if (id_decrementAndGet == IntPtr.Zero)
				id_decrementAndGet = JNIEnv.GetMethodID (class_ref, "decrementAndGet", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_decrementAndGet);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrementAndGet", "()D"));
			} finally {
			}
		}

		static Delegate cb_doubleValue;
#pragma warning disable 0169
		static Delegate GetDoubleValueHandler ()
		{
			if (cb_doubleValue == null)
				cb_doubleValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_DoubleValue);
			return cb_doubleValue;
		}

		static double n_DoubleValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleValue ();
		}
#pragma warning restore 0169

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "GetDoubleValueHandler")]
		public override unsafe double DoubleValue ()
		{
			if (id_doubleValue == IntPtr.Zero)
				id_doubleValue = JNIEnv.GetMethodID (class_ref, "doubleValue", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_doubleValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doubleValue", "()D"));
			} finally {
			}
		}

		static Delegate cb_floatValue;
#pragma warning disable 0169
		static Delegate GetFloatValueHandler ()
		{
			if (cb_floatValue == null)
				cb_floatValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_FloatValue);
			return cb_floatValue;
		}

		static float n_FloatValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FloatValue ();
		}
#pragma warning restore 0169

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "GetFloatValueHandler")]
		public override unsafe float FloatValue ()
		{
			if (id_floatValue == IntPtr.Zero)
				id_floatValue = JNIEnv.GetMethodID (class_ref, "floatValue", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_floatValue);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "floatValue", "()F"));
			} finally {
			}
		}

		static Delegate cb_getAndAdd_D;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_DHandler ()
		{
			if (cb_getAndAdd_D == null)
				cb_getAndAdd_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_D) n_GetAndAdd_D);
			return cb_getAndAdd_D;
		}

		static double n_GetAndAdd_D (IntPtr jnienv, IntPtr native__this, double operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAndAdd (operand);
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getAndAdd", "(D)D", "GetGetAndAdd_DHandler")]
		public virtual unsafe double GetAndAdd (double operand)
		{
			if (id_getAndAdd_D == IntPtr.Zero)
				id_getAndAdd_D = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_D, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(D)D"), __args);
			} finally {
			}
		}

		static Delegate cb_getAndAdd_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_Ljava_lang_Number_Handler ()
		{
			if (cb_getAndAdd_Ljava_lang_Number_ == null)
				cb_getAndAdd_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_D) n_GetAndAdd_Ljava_lang_Number_);
			return cb_getAndAdd_Ljava_lang_Number_;
		}

		static double n_GetAndAdd_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetAndAdd (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("getAndAdd", "(Ljava/lang/Number;)D", "GetGetAndAdd_Ljava_lang_Number_Handler")]
		public virtual unsafe double GetAndAdd (global::Java.Lang.Number operand)
		{
			if (id_getAndAdd_Ljava_lang_Number_ == IntPtr.Zero)
				id_getAndAdd_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(Ljava/lang/Number;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				double __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(Ljava/lang/Number;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_increment;
#pragma warning disable 0169
		static Delegate GetIncrementHandler ()
		{
			if (cb_increment == null)
				cb_increment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Increment);
			return cb_increment;
		}

		static void n_Increment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment ();
		}
#pragma warning restore 0169

		static IntPtr id_increment;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='increment' and count(parameter)=0]"
		[Register ("increment", "()V", "GetIncrementHandler")]
		public virtual unsafe void Increment ()
		{
			if (id_increment == IntPtr.Zero)
				id_increment = JNIEnv.GetMethodID (class_ref, "increment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_increment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "()V"));
			} finally {
			}
		}

		static Delegate cb_incrementAndGet;
#pragma warning disable 0169
		static Delegate GetIncrementAndGetHandler ()
		{
			if (cb_incrementAndGet == null)
				cb_incrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_IncrementAndGet);
			return cb_incrementAndGet;
		}

		static double n_IncrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='incrementAndGet' and count(parameter)=0]"
		[Register ("incrementAndGet", "()D", "GetIncrementAndGetHandler")]
		public virtual unsafe double IncrementAndGet ()
		{
			if (id_incrementAndGet == IntPtr.Zero)
				id_incrementAndGet = JNIEnv.GetMethodID (class_ref, "incrementAndGet", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndGet);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndGet", "()D"));
			} finally {
			}
		}

		static Delegate cb_intValue;
#pragma warning disable 0169
		static Delegate GetIntValueHandler ()
		{
			if (cb_intValue == null)
				cb_intValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_IntValue);
			return cb_intValue;
		}

		static int n_IntValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntValue ();
		}
#pragma warning restore 0169

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "GetIntValueHandler")]
		public override unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_intValue);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intValue", "()I"));
			} finally {
			}
		}

		static Delegate cb_longValue;
#pragma warning disable 0169
		static Delegate GetLongValueHandler ()
		{
			if (cb_longValue == null)
				cb_longValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_LongValue);
			return cb_longValue;
		}

		static long n_LongValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "GetLongValueHandler")]
		public override unsafe long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_longValue);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "longValue", "()J"));
			} finally {
			}
		}

		static Delegate cb_setValue_D;
#pragma warning disable 0169
		static Delegate GetSetValue_DHandler ()
		{
			if (cb_setValue_D == null)
				cb_setValue_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetValue_D);
			return cb_setValue_D;
		}

		static void n_SetValue_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setValue", "(D)V", "GetSetValue_DHandler")]
		public virtual unsafe void SetValue (double value)
		{
			if (id_setValue_D == IntPtr.Zero)
				id_setValue_D = JNIEnv.GetMethodID (class_ref, "setValue", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setValue_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Number_Handler ()
		{
			if (cb_setValue_Ljava_lang_Number_ == null)
				cb_setValue_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_Number_);
			return cb_setValue_Ljava_lang_Number_;
		}

		static void n_SetValue_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("setValue", "(Ljava/lang/Number;)V", "GetSetValue_Ljava_lang_Number_Handler")]
		public virtual unsafe void SetValue (global::Java.Lang.Number value)
		{
			if (id_setValue_Ljava_lang_Number_ == IntPtr.Zero)
				id_setValue_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subtract_D;
#pragma warning disable 0169
		static Delegate GetSubtract_DHandler ()
		{
			if (cb_subtract_D == null)
				cb_subtract_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_Subtract_D);
			return cb_subtract_D;
		}

		static void n_Subtract_D (IntPtr jnienv, IntPtr native__this, double operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("subtract", "(D)V", "GetSubtract_DHandler")]
		public virtual unsafe void Subtract (double operand)
		{
			if (id_subtract_D == IntPtr.Zero)
				id_subtract_D = JNIEnv.GetMethodID (class_ref, "subtract", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subtract_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subtract_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSubtract_Ljava_lang_Number_Handler ()
		{
			if (cb_subtract_Ljava_lang_Number_ == null)
				cb_subtract_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subtract_Ljava_lang_Number_);
			return cb_subtract_Ljava_lang_Number_;
		}

		static void n_Subtract_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("subtract", "(Ljava/lang/Number;)V", "GetSubtract_Ljava_lang_Number_Handler")]
		public virtual unsafe void Subtract (global::Java.Lang.Number operand)
		{
			if (id_subtract_Ljava_lang_Number_ == IntPtr.Zero)
				id_subtract_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "subtract", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subtract_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toDouble;
#pragma warning disable 0169
		static Delegate GetToDoubleHandler ()
		{
			if (cb_toDouble == null)
				cb_toDouble = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToDouble);
			return cb_toDouble;
		}

		static IntPtr n_ToDouble (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToDouble ());
		}
#pragma warning restore 0169

		static IntPtr id_toDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableDouble']/method[@name='toDouble' and count(parameter)=0]"
		[Register ("toDouble", "()Ljava/lang/Double;", "GetToDoubleHandler")]
		public virtual unsafe global::Java.Lang.Double ToDouble ()
		{
			if (id_toDouble == IntPtr.Zero)
				id_toDouble = JNIEnv.GetMethodID (class_ref, "toDouble", "()Ljava/lang/Double;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toDouble), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toDouble", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
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
				Value = global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Number>(value);
			}
		}

	}
}
