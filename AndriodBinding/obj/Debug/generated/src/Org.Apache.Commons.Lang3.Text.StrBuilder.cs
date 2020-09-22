using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrBuilder", DoNotGenerateAcw=true)]
	public partial class StrBuilder : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IAppendable, global::Java.Lang.ICharSequence, global::Org.Apache.Commons.Lang3.Builder.IBuilder {


		static IntPtr buffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/field[@name='buffer']"
		[Register ("buffer")]
		protected IList<char> Buffer {
			get {
				if (buffer_jfieldId == IntPtr.Zero)
					buffer_jfieldId = JNIEnv.GetFieldID (class_ref, "buffer", "[C");
				return global::Android.Runtime.JavaArray<char>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, buffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (buffer_jfieldId == IntPtr.Zero)
					buffer_jfieldId = JNIEnv.GetFieldID (class_ref, "buffer", "[C");
				IntPtr native_value = global::Android.Runtime.JavaArray<char>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/StrBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrBuilder); }
		}

		protected StrBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/constructor[@name='StrBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StrBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StrBuilder)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/constructor[@name='StrBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe StrBuilder (int initialCapacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (initialCapacity);
				if (((object) this).GetType () != typeof (StrBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/constructor[@name='StrBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StrBuilder (string str)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				if (((object) this).GetType () != typeof (StrBuilder)) {
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
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNewLineText;
#pragma warning disable 0169
		static Delegate GetGetNewLineTextHandler ()
		{
			if (cb_getNewLineText == null)
				cb_getNewLineText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewLineText);
			return cb_getNewLineText;
		}

		static IntPtr n_GetNewLineText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewLineText);
		}
#pragma warning restore 0169

		static IntPtr id_getNewLineText;
		public virtual unsafe string NewLineText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='getNewLineText' and count(parameter)=0]"
			[Register ("getNewLineText", "()Ljava/lang/String;", "GetGetNewLineTextHandler")]
			get {
				if (id_getNewLineText == IntPtr.Zero)
					id_getNewLineText = JNIEnv.GetMethodID (class_ref, "getNewLineText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewLineText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewLineText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNullText;
#pragma warning disable 0169
		static Delegate GetGetNullTextHandler ()
		{
			if (cb_getNullText == null)
				cb_getNullText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNullText);
			return cb_getNullText;
		}

		static IntPtr n_GetNullText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NullText);
		}
#pragma warning restore 0169

		static IntPtr id_getNullText;
		public virtual unsafe string NullText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='getNullText' and count(parameter)=0]"
			[Register ("getNullText", "()Ljava/lang/String;", "GetGetNullTextHandler")]
			get {
				if (id_getNullText == IntPtr.Zero)
					id_getNullText = JNIEnv.GetMethodID (class_ref, "getNullText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNullText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNullText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_append_Z;
#pragma warning disable 0169
		static Delegate GetAppend_ZHandler ()
		{
			if (cb_append_Z == null)
				cb_append_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Append_Z);
			return cb_append_Z;
		}

		static IntPtr n_Append_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("append", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (bool value)
		{
			if (id_append_Z == IntPtr.Zero)
				id_append_Z = JNIEnv.GetMethodID (class_ref, "append", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_C;
#pragma warning disable 0169
		static Delegate GetAppend_CHandler ()
		{
			if (cb_append_C == null)
				cb_append_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_Append_C);
			return cb_append_C;
		}

		static IntPtr n_Append_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (ch));
		}
#pragma warning restore 0169

		static IntPtr id_append_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("append", "(C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (char ch)
		{
			if (id_append_C == IntPtr.Zero)
				id_append_C = JNIEnv.GetMethodID (class_ref, "append", "(C)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_arrayC;
#pragma warning disable 0169
		static Delegate GetAppend_arrayCHandler ()
		{
			if (cb_append_arrayC == null)
				cb_append_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_arrayC);
			return cb_append_arrayC;
		}

		static IntPtr n_Append_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_chars)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (chars));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("append", "([C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (char[] chars)
		{
			if (id_append_arrayC == IntPtr.Zero)
				id_append_arrayC = JNIEnv.GetMethodID (class_ref, "append", "([C)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_append_arrayCII;
#pragma warning disable 0169
		static Delegate GetAppend_arrayCIIHandler ()
		{
			if (cb_append_arrayCII == null)
				cb_append_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_arrayCII);
			return cb_append_arrayCII;
		}

		static IntPtr n_Append_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_chars, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (chars, startIndex, length));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_arrayCIIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (char[] chars, int startIndex, int length)
		{
			if (id_append_arrayCII == IntPtr.Zero)
				id_append_arrayCII = JNIEnv.GetMethodID (class_ref, "append", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_arrayCII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_append_D;
#pragma warning disable 0169
		static Delegate GetAppend_DHandler ()
		{
			if (cb_append_D == null)
				cb_append_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_L) n_Append_D);
			return cb_append_D;
		}

		static IntPtr n_Append_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("append", "(D)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_DHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (double value)
		{
			if (id_append_D == IntPtr.Zero)
				id_append_D = JNIEnv.GetMethodID (class_ref, "append", "(D)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(D)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_F;
#pragma warning disable 0169
		static Delegate GetAppend_FHandler ()
		{
			if (cb_append_F == null)
				cb_append_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_Append_F);
			return cb_append_F;
		}

		static IntPtr n_Append_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("append", "(F)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_FHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (float value)
		{
			if (id_append_F == IntPtr.Zero)
				id_append_F = JNIEnv.GetMethodID (class_ref, "append", "(F)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(F)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_I;
#pragma warning disable 0169
		static Delegate GetAppend_IHandler ()
		{
			if (cb_append_I == null)
				cb_append_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Append_I);
			return cb_append_I;
		}

		static IntPtr n_Append_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("append", "(I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (int value)
		{
			if (id_append_I == IntPtr.Zero)
				id_append_I = JNIEnv.GetMethodID (class_ref, "append", "(I)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_append_Ljava_lang_CharSequence_ == null)
				cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_CharSequence_);
			return cb_append_Ljava_lang_CharSequence_;
		}

		static IntPtr n_Append_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_seq)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var seq = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_seq, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (seq));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("append", "(Ljava/lang/CharSequence;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.ICharSequence seq)
		{
			if (id_append_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/CharSequence;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_seq);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/CharSequence;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		static Delegate cb_append_Ljava_lang_CharSequence_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler ()
		{
			if (cb_append_Ljava_lang_CharSequence_II == null)
				cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_lang_CharSequence_II);
			return cb_append_Ljava_lang_CharSequence_II;
		}

		static IntPtr n_Append_Ljava_lang_CharSequence_II (IntPtr jnienv, IntPtr native__this, IntPtr native_seq, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var seq = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_seq, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (seq, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/CharSequence;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_CharSequence_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.ICharSequence seq, int startIndex, int length)
		{
			if (id_append_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_append_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/CharSequence;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_seq = CharSequence.ToLocalJniHandle (seq);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_seq);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_CharSequence_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/CharSequence;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_seq);
			}
		}

		static Delegate cb_append_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_Object_ == null)
				cb_append_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_Object_);
			return cb_append_Ljava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.Object obj)
		{
			if (id_append_Ljava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Handler ()
		{
			if (cb_append_Ljava_lang_String_ == null)
				cb_append_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_String_);
			return cb_append_Ljava_lang_String_;
		}

		static IntPtr n_Append_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("append", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (string str)
		{
			if (id_append_Ljava_lang_String_ == IntPtr.Zero)
				id_append_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_append_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_IIHandler ()
		{
			if (cb_append_Ljava_lang_String_II == null)
				cb_append_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_lang_String_II);
			return cb_append_Ljava_lang_String_II;
		}

		static IntPtr n_Append_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (string str, int startIndex, int length)
		{
			if (id_append_Ljava_lang_String_II == IntPtr.Zero)
				id_append_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Append_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_Append_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_objs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var objs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_objs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (format, objs));
			if (objs != null)
				JNIEnv.CopyArray (objs, native_objs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (string format, params global::Java.Lang.Object[] objs)
		{
			if (id_append_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_objs = JNIEnv.NewArray (objs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_format);
				__args [1] = new JValue (native_objs);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (objs != null) {
					JNIEnv.CopyArray (native_objs, objs);
					JNIEnv.DeleteLocalRef (native_objs);
				}
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_ == null)
				cb_append_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_StringBuffer_);
			return cb_append_Ljava_lang_StringBuffer_;
		}

		static IntPtr n_Append_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("append", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.StringBuffer str)
		{
			if (id_append_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuffer_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuffer_IIHandler ()
		{
			if (cb_append_Ljava_lang_StringBuffer_II == null)
				cb_append_Ljava_lang_StringBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_lang_StringBuffer_II);
			return cb_append_Ljava_lang_StringBuffer_II;
		}

		static IntPtr n_Append_Ljava_lang_StringBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_StringBuffer_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.StringBuffer str, int startIndex, int length)
		{
			if (id_append_Ljava_lang_StringBuffer_II == IntPtr.Zero)
				id_append_Ljava_lang_StringBuffer_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuilder_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuilder_ == null)
				cb_append_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_lang_StringBuilder_);
			return cb_append_Ljava_lang_StringBuilder_;
		}

		static IntPtr n_Append_Ljava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register ("append", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_StringBuilder_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.StringBuilder str)
		{
			if (id_append_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuilder_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuilder_IIHandler ()
		{
			if (cb_append_Ljava_lang_StringBuilder_II == null)
				cb_append_Ljava_lang_StringBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_lang_StringBuilder_II);
			return cb_append_Ljava_lang_StringBuilder_II;
		}

		static IntPtr n_Append_Ljava_lang_StringBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_lang_StringBuilder_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Lang.StringBuilder str, int startIndex, int length)
		{
			if (id_append_Ljava_lang_StringBuilder_II == IntPtr.Zero)
				id_append_Ljava_lang_StringBuilder_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_lang_StringBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_nio_CharBuffer_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_nio_CharBuffer_Handler ()
		{
			if (cb_append_Ljava_nio_CharBuffer_ == null)
				cb_append_Ljava_nio_CharBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Ljava_nio_CharBuffer_);
			return cb_append_Ljava_nio_CharBuffer_;
		}

		static IntPtr n_Append_Ljava_nio_CharBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Nio.CharBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_nio_CharBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.nio.CharBuffer']]"
		[Register ("append", "(Ljava/nio/CharBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_nio_CharBuffer_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Nio.CharBuffer buf)
		{
			if (id_append_Ljava_nio_CharBuffer_ == IntPtr.Zero)
				id_append_Ljava_nio_CharBuffer_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/nio/CharBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buf);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_nio_CharBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/nio/CharBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Ljava_nio_CharBuffer_II;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_nio_CharBuffer_IIHandler ()
		{
			if (cb_append_Ljava_nio_CharBuffer_II == null)
				cb_append_Ljava_nio_CharBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Ljava_nio_CharBuffer_II);
			return cb_append_Ljava_nio_CharBuffer_II;
		}

		static IntPtr n_Append_Ljava_nio_CharBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Nio.CharBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (buf, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_nio_CharBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.nio.CharBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Ljava/nio/CharBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Ljava_nio_CharBuffer_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Java.Nio.CharBuffer buf, int startIndex, int length)
		{
			if (id_append_Ljava_nio_CharBuffer_II == IntPtr.Zero)
				id_append_Ljava_nio_CharBuffer_II = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/nio/CharBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buf);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Ljava_nio_CharBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/nio/CharBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_J;
#pragma warning disable 0169
		static Delegate GetAppend_JHandler ()
		{
			if (cb_append_J == null)
				cb_append_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Append_J);
			return cb_append_J;
		}

		static IntPtr n_Append_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Append (value));
		}
#pragma warning restore 0169

		static IntPtr id_append_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("append", "(J)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_JHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (long value)
		{
			if (id_append_J == IntPtr.Zero)
				id_append_J = JNIEnv.GetMethodID (class_ref, "append", "(J)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(J)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_append_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetAppend_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_append_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_append_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Append_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_append_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static IntPtr n_Append_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("append", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Org.Apache.Commons.Lang3.Text.StrBuilder str)
		{
			if (id_append_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_append_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "append", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Lorg_apache_commons_lang3_text_StrBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_append_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetAppend_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_append_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_append_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Append_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_append_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static IntPtr n_Append_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='append' and count(parameter)=3 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("append", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppend_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Append (global::Org.Apache.Commons.Lang3.Text.StrBuilder str, int startIndex, int length)
		{
			if (id_append_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_append_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "append", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Lorg_apache_commons_lang3_text_StrBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendAll_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetAppendAll_Ljava_lang_Iterable_Handler ()
		{
			if (cb_appendAll_Ljava_lang_Iterable_ == null)
				cb_appendAll_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendAll_Ljava_lang_Iterable_);
			return cb_appendAll_Ljava_lang_Iterable_;
		}

		static IntPtr n_AppendAll_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iterable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iterable = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_iterable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendAll (iterable));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendAll_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendAll' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;?&gt;']]"
		[Register ("appendAll", "(Ljava/lang/Iterable;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendAll_Ljava_lang_Iterable_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendAll (global::Java.Lang.IIterable iterable)
		{
			if (id_appendAll_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_appendAll_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "appendAll", "(Ljava/lang/Iterable;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (iterable);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendAll_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAll", "(Ljava/lang/Iterable;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendAll_Ljava_util_Iterator_;
#pragma warning disable 0169
		static Delegate GetAppendAll_Ljava_util_Iterator_Handler ()
		{
			if (cb_appendAll_Ljava_util_Iterator_ == null)
				cb_appendAll_Ljava_util_Iterator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendAll_Ljava_util_Iterator_);
			return cb_appendAll_Ljava_util_Iterator_;
		}

		static IntPtr n_AppendAll_Ljava_util_Iterator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_it)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var it = (global::Java.Util.IIterator)global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (native_it, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendAll (it));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendAll_Ljava_util_Iterator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendAll' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;?&gt;']]"
		[Register ("appendAll", "(Ljava/util/Iterator;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendAll_Ljava_util_Iterator_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendAll (global::Java.Util.IIterator it)
		{
			if (id_appendAll_Ljava_util_Iterator_ == IntPtr.Zero)
				id_appendAll_Ljava_util_Iterator_ = JNIEnv.GetMethodID (class_ref, "appendAll", "(Ljava/util/Iterator;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (it);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendAll_Ljava_util_Iterator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAll", "(Ljava/util/Iterator;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendAll_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendAll_arrayLjava_lang_Object_Handler ()
		{
			if (cb_appendAll_arrayLjava_lang_Object_ == null)
				cb_appendAll_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendAll_arrayLjava_lang_Object_);
			return cb_appendAll_arrayLjava_lang_Object_;
		}

		static IntPtr n_AppendAll_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendAll (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendAll_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendAll' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("appendAll", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendAll_arrayLjava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendAll (params global::Java.Lang.Object[] array)
		{
			if (id_appendAll_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_appendAll_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendAll", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendAll_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAll", "([Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_appendFixedWidthPadLeft_IIC;
#pragma warning disable 0169
		static Delegate GetAppendFixedWidthPadLeft_IICHandler ()
		{
			if (cb_appendFixedWidthPadLeft_IIC == null)
				cb_appendFixedWidthPadLeft_IIC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIC_L) n_AppendFixedWidthPadLeft_IIC);
			return cb_appendFixedWidthPadLeft_IIC;
		}

		static IntPtr n_AppendFixedWidthPadLeft_IIC (IntPtr jnienv, IntPtr native__this, int value, int width, char padChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendFixedWidthPadLeft (value, width, padChar));
		}
#pragma warning restore 0169

		static IntPtr id_appendFixedWidthPadLeft_IIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendFixedWidthPadLeft' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("appendFixedWidthPadLeft", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendFixedWidthPadLeft_IICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendFixedWidthPadLeft (int value, int width, char padChar)
		{
			if (id_appendFixedWidthPadLeft_IIC == IntPtr.Zero)
				id_appendFixedWidthPadLeft_IIC = JNIEnv.GetMethodID (class_ref, "appendFixedWidthPadLeft", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (width);
				__args [2] = new JValue (padChar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendFixedWidthPadLeft_IIC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFixedWidthPadLeft", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendFixedWidthPadLeft_Ljava_lang_Object_IC;
#pragma warning disable 0169
		static Delegate GetAppendFixedWidthPadLeft_Ljava_lang_Object_ICHandler ()
		{
			if (cb_appendFixedWidthPadLeft_Ljava_lang_Object_IC == null)
				cb_appendFixedWidthPadLeft_Ljava_lang_Object_IC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIC_L) n_AppendFixedWidthPadLeft_Ljava_lang_Object_IC);
			return cb_appendFixedWidthPadLeft_Ljava_lang_Object_IC;
		}

		static IntPtr n_AppendFixedWidthPadLeft_Ljava_lang_Object_IC (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, int width, char padChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendFixedWidthPadLeft (obj, width, padChar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendFixedWidthPadLeft_Ljava_lang_Object_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendFixedWidthPadLeft' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("appendFixedWidthPadLeft", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendFixedWidthPadLeft_Ljava_lang_Object_ICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendFixedWidthPadLeft (global::Java.Lang.Object obj, int width, char padChar)
		{
			if (id_appendFixedWidthPadLeft_Ljava_lang_Object_IC == IntPtr.Zero)
				id_appendFixedWidthPadLeft_Ljava_lang_Object_IC = JNIEnv.GetMethodID (class_ref, "appendFixedWidthPadLeft", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (width);
				__args [2] = new JValue (padChar);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendFixedWidthPadLeft_Ljava_lang_Object_IC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFixedWidthPadLeft", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendFixedWidthPadRight_IIC;
#pragma warning disable 0169
		static Delegate GetAppendFixedWidthPadRight_IICHandler ()
		{
			if (cb_appendFixedWidthPadRight_IIC == null)
				cb_appendFixedWidthPadRight_IIC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIC_L) n_AppendFixedWidthPadRight_IIC);
			return cb_appendFixedWidthPadRight_IIC;
		}

		static IntPtr n_AppendFixedWidthPadRight_IIC (IntPtr jnienv, IntPtr native__this, int value, int width, char padChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendFixedWidthPadRight (value, width, padChar));
		}
#pragma warning restore 0169

		static IntPtr id_appendFixedWidthPadRight_IIC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendFixedWidthPadRight' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("appendFixedWidthPadRight", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendFixedWidthPadRight_IICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendFixedWidthPadRight (int value, int width, char padChar)
		{
			if (id_appendFixedWidthPadRight_IIC == IntPtr.Zero)
				id_appendFixedWidthPadRight_IIC = JNIEnv.GetMethodID (class_ref, "appendFixedWidthPadRight", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (value);
				__args [1] = new JValue (width);
				__args [2] = new JValue (padChar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendFixedWidthPadRight_IIC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFixedWidthPadRight", "(IIC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendFixedWidthPadRight_Ljava_lang_Object_IC;
#pragma warning disable 0169
		static Delegate GetAppendFixedWidthPadRight_Ljava_lang_Object_ICHandler ()
		{
			if (cb_appendFixedWidthPadRight_Ljava_lang_Object_IC == null)
				cb_appendFixedWidthPadRight_Ljava_lang_Object_IC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIC_L) n_AppendFixedWidthPadRight_Ljava_lang_Object_IC);
			return cb_appendFixedWidthPadRight_Ljava_lang_Object_IC;
		}

		static IntPtr n_AppendFixedWidthPadRight_Ljava_lang_Object_IC (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, int width, char padChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendFixedWidthPadRight (obj, width, padChar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendFixedWidthPadRight_Ljava_lang_Object_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendFixedWidthPadRight' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("appendFixedWidthPadRight", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendFixedWidthPadRight_Ljava_lang_Object_ICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendFixedWidthPadRight (global::Java.Lang.Object obj, int width, char padChar)
		{
			if (id_appendFixedWidthPadRight_Ljava_lang_Object_IC == IntPtr.Zero)
				id_appendFixedWidthPadRight_Ljava_lang_Object_IC = JNIEnv.GetMethodID (class_ref, "appendFixedWidthPadRight", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (width);
				__args [2] = new JValue (padChar);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendFixedWidthPadRight_Ljava_lang_Object_IC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendFixedWidthPadRight", "(Ljava/lang/Object;IC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendNewLine;
#pragma warning disable 0169
		static Delegate GetAppendNewLineHandler ()
		{
			if (cb_appendNewLine == null)
				cb_appendNewLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AppendNewLine);
			return cb_appendNewLine;
		}

		static IntPtr n_AppendNewLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendNewLine ());
		}
#pragma warning restore 0169

		static IntPtr id_appendNewLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendNewLine' and count(parameter)=0]"
		[Register ("appendNewLine", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendNewLineHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendNewLine ()
		{
			if (id_appendNewLine == IntPtr.Zero)
				id_appendNewLine = JNIEnv.GetMethodID (class_ref, "appendNewLine", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendNewLine), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendNewLine", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendNull;
#pragma warning disable 0169
		static Delegate GetAppendNullHandler ()
		{
			if (cb_appendNull == null)
				cb_appendNull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AppendNull);
			return cb_appendNull;
		}

		static IntPtr n_AppendNull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendNull ());
		}
#pragma warning restore 0169

		static IntPtr id_appendNull;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendNull' and count(parameter)=0]"
		[Register ("appendNull", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendNullHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendNull ()
		{
			if (id_appendNull == IntPtr.Zero)
				id_appendNull = JNIEnv.GetMethodID (class_ref, "appendNull", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendNull), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendNull", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendPadding_IC;
#pragma warning disable 0169
		static Delegate GetAppendPadding_ICHandler ()
		{
			if (cb_appendPadding_IC == null)
				cb_appendPadding_IC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIC_L) n_AppendPadding_IC);
			return cb_appendPadding_IC;
		}

		static IntPtr n_AppendPadding_IC (IntPtr jnienv, IntPtr native__this, int length, char padChar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendPadding (length, padChar));
		}
#pragma warning restore 0169

		static IntPtr id_appendPadding_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendPadding' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='char']]"
		[Register ("appendPadding", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendPadding_ICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendPadding (int length, char padChar)
		{
			if (id_appendPadding_IC == IntPtr.Zero)
				id_appendPadding_IC = JNIEnv.GetMethodID (class_ref, "appendPadding", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (length);
				__args [1] = new JValue (padChar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendPadding_IC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendPadding", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendSeparator_C;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_CHandler ()
		{
			if (cb_appendSeparator_C == null)
				cb_appendSeparator_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_AppendSeparator_C);
			return cb_appendSeparator_C;
		}

		static IntPtr n_AppendSeparator_C (IntPtr jnienv, IntPtr native__this, char separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSeparator (separator));
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("appendSeparator", "(C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (char separator)
		{
			if (id_appendSeparator_C == IntPtr.Zero)
				id_appendSeparator_C = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(C)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (separator);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendSeparator_CC;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_CCHandler ()
		{
			if (cb_appendSeparator_CC == null)
				cb_appendSeparator_CC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCC_L) n_AppendSeparator_CC);
			return cb_appendSeparator_CC;
		}

		static IntPtr n_AppendSeparator_CC (IntPtr jnienv, IntPtr native__this, char standard, char defaultIfEmpty)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSeparator (standard, defaultIfEmpty));
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("appendSeparator", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (char standard, char defaultIfEmpty)
		{
			if (id_appendSeparator_CC == IntPtr.Zero)
				id_appendSeparator_CC = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (standard);
				__args [1] = new JValue (defaultIfEmpty);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendSeparator_CI;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_CIHandler ()
		{
			if (cb_appendSeparator_CI == null)
				cb_appendSeparator_CI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCI_L) n_AppendSeparator_CI);
			return cb_appendSeparator_CI;
		}

		static IntPtr n_AppendSeparator_CI (IntPtr jnienv, IntPtr native__this, char separator, int loopIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppendSeparator (separator, loopIndex));
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("appendSeparator", "(CI)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_CIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (char separator, int loopIndex)
		{
			if (id_appendSeparator_CI == IntPtr.Zero)
				id_appendSeparator_CI = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(CI)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (separator);
				__args [1] = new JValue (loopIndex);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_CI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(CI)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendSeparator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_Ljava_lang_String_Handler ()
		{
			if (cb_appendSeparator_Ljava_lang_String_ == null)
				cb_appendSeparator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AppendSeparator_Ljava_lang_String_);
			return cb_appendSeparator_Ljava_lang_String_;
		}

		static IntPtr n_AppendSeparator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var separator = JNIEnv.GetString (native_separator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendSeparator (separator));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("appendSeparator", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (string separator)
		{
			if (id_appendSeparator_Ljava_lang_String_ == IntPtr.Zero)
				id_appendSeparator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_separator);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static Delegate cb_appendSeparator_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_Ljava_lang_String_IHandler ()
		{
			if (cb_appendSeparator_Ljava_lang_String_I == null)
				cb_appendSeparator_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AppendSeparator_Ljava_lang_String_I);
			return cb_appendSeparator_Ljava_lang_String_I;
		}

		static IntPtr n_AppendSeparator_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_separator, int loopIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var separator = JNIEnv.GetString (native_separator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendSeparator (separator, loopIndex));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("appendSeparator", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (string separator, int loopIndex)
		{
			if (id_appendSeparator_Ljava_lang_String_I == IntPtr.Zero)
				id_appendSeparator_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_separator);
				__args [1] = new JValue (loopIndex);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(Ljava/lang/String;I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static Delegate cb_appendSeparator_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendSeparator_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_appendSeparator_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_appendSeparator_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AppendSeparator_Ljava_lang_String_Ljava_lang_String_);
			return cb_appendSeparator_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AppendSeparator_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_standard, IntPtr native_defaultIfEmpty)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var standard = JNIEnv.GetString (native_standard, JniHandleOwnership.DoNotTransfer);
			var defaultIfEmpty = JNIEnv.GetString (native_defaultIfEmpty, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendSeparator (standard, defaultIfEmpty));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendSeparator_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendSeparator' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendSeparator", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendSeparator_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendSeparator (string standard, string defaultIfEmpty)
		{
			if (id_appendSeparator_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_appendSeparator_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendSeparator", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_standard = JNIEnv.NewString (standard);
			IntPtr native_defaultIfEmpty = JNIEnv.NewString (defaultIfEmpty);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_standard);
				__args [1] = new JValue (native_defaultIfEmpty);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendSeparator_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendSeparator", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_standard);
				JNIEnv.DeleteLocalRef (native_defaultIfEmpty);
			}
		}

		static Delegate cb_appendTo_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetAppendTo_Ljava_lang_Appendable_Handler ()
		{
			if (cb_appendTo_Ljava_lang_Appendable_ == null)
				cb_appendTo_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AppendTo_Ljava_lang_Appendable_);
			return cb_appendTo_Ljava_lang_Appendable_;
		}

		static void n_AppendTo_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appendable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appendable = (global::Java.Lang.IAppendable)global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (native_appendable, JniHandleOwnership.DoNotTransfer);
			__this.AppendTo (appendable);
		}
#pragma warning restore 0169

		static IntPtr id_appendTo_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendTo' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("appendTo", "(Ljava/lang/Appendable;)V", "GetAppendTo_Ljava_lang_Appendable_Handler")]
		public virtual unsafe void AppendTo (global::Java.Lang.IAppendable appendable)
		{
			if (id_appendTo_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_appendTo_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "appendTo", "(Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (appendable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendTo_Ljava_lang_Appendable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendTo", "(Ljava/lang/Appendable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_Handler ()
		{
			if (cb_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_ == null)
				cb_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AppendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_);
			return cb_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_;
		}

		static IntPtr n_AppendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iterable, IntPtr native_separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iterable = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_iterable, JniHandleOwnership.DoNotTransfer);
			var separator = JNIEnv.GetString (native_separator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendWithSeparators (iterable, separator));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendWithSeparators' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendWithSeparators", "(Ljava/lang/Iterable;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendWithSeparators (global::Java.Lang.IIterable iterable, string separator)
		{
			if (id_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_ == IntPtr.Zero)
				id_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendWithSeparators", "(Ljava/lang/Iterable;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (iterable);
				__args [1] = new JValue (native_separator);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendWithSeparators_Ljava_lang_Iterable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendWithSeparators", "(Ljava/lang/Iterable;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static Delegate cb_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_ == null)
				cb_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AppendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_);
			return cb_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_;
		}

		static IntPtr n_AppendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array, IntPtr native_separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var separator = JNIEnv.GetString (native_separator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendWithSeparators (array, separator));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendWithSeparators' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendWithSeparators", "([Ljava/lang/Object;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendWithSeparators (global::Java.Lang.Object[] array, string separator)
		{
			if (id_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendWithSeparators", "([Ljava/lang/Object;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_array);
				__args [1] = new JValue (native_separator);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendWithSeparators_arrayLjava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendWithSeparators", "([Ljava/lang/Object;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static Delegate cb_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_Handler ()
		{
			if (cb_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_ == null)
				cb_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AppendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_);
			return cb_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_;
		}

		static IntPtr n_AppendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_it, IntPtr native_separator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var it = (global::Java.Util.IIterator)global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (native_it, JniHandleOwnership.DoNotTransfer);
			var separator = JNIEnv.GetString (native_separator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AppendWithSeparators (it, separator));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendWithSeparators' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendWithSeparators", "(Ljava/util/Iterator;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder AppendWithSeparators (global::Java.Util.IIterator it, string separator)
		{
			if (id_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_ == IntPtr.Zero)
				id_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendWithSeparators", "(Ljava/util/Iterator;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_separator = JNIEnv.NewString (separator);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (it);
				__args [1] = new JValue (native_separator);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendWithSeparators_Ljava_util_Iterator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendWithSeparators", "(Ljava/util/Iterator;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_separator);
			}
		}

		static Delegate cb_appendln_Z;
#pragma warning disable 0169
		static Delegate GetAppendln_ZHandler ()
		{
			if (cb_appendln_Z == null)
				cb_appendln_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Appendln_Z);
			return cb_appendln_Z;
		}

		static IntPtr n_Appendln_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (value));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("appendln", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_ZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (bool value)
		{
			if (id_appendln_Z == IntPtr.Zero)
				id_appendln_Z = JNIEnv.GetMethodID (class_ref, "appendln", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Z)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_C;
#pragma warning disable 0169
		static Delegate GetAppendln_CHandler ()
		{
			if (cb_appendln_C == null)
				cb_appendln_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_Appendln_C);
			return cb_appendln_C;
		}

		static IntPtr n_Appendln_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (ch));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("appendln", "(C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (char ch)
		{
			if (id_appendln_C == IntPtr.Zero)
				id_appendln_C = JNIEnv.GetMethodID (class_ref, "appendln", "(C)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_arrayC;
#pragma warning disable 0169
		static Delegate GetAppendln_arrayCHandler ()
		{
			if (cb_appendln_arrayC == null)
				cb_appendln_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_arrayC);
			return cb_appendln_arrayC;
		}

		static IntPtr n_Appendln_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_chars)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (chars));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("appendln", "([C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_arrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (char[] chars)
		{
			if (id_appendln_arrayC == IntPtr.Zero)
				id_appendln_arrayC = JNIEnv.GetMethodID (class_ref, "appendln", "([C)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chars);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "([C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_appendln_arrayCII;
#pragma warning disable 0169
		static Delegate GetAppendln_arrayCIIHandler ()
		{
			if (cb_appendln_arrayCII == null)
				cb_appendln_arrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Appendln_arrayCII);
			return cb_appendln_arrayCII;
		}

		static IntPtr n_Appendln_arrayCII (IntPtr jnienv, IntPtr native__this, IntPtr native_chars, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (chars, startIndex, length));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_arrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("appendln", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_arrayCIIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (char[] chars, int startIndex, int length)
		{
			if (id_appendln_arrayCII == IntPtr.Zero)
				id_appendln_arrayCII = JNIEnv.GetMethodID (class_ref, "appendln", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_chars);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_arrayCII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "([CII)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_appendln_D;
#pragma warning disable 0169
		static Delegate GetAppendln_DHandler ()
		{
			if (cb_appendln_D == null)
				cb_appendln_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_L) n_Appendln_D);
			return cb_appendln_D;
		}

		static IntPtr n_Appendln_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (value));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("appendln", "(D)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_DHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (double value)
		{
			if (id_appendln_D == IntPtr.Zero)
				id_appendln_D = JNIEnv.GetMethodID (class_ref, "appendln", "(D)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(D)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_F;
#pragma warning disable 0169
		static Delegate GetAppendln_FHandler ()
		{
			if (cb_appendln_F == null)
				cb_appendln_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_Appendln_F);
			return cb_appendln_F;
		}

		static IntPtr n_Appendln_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (value));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("appendln", "(F)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_FHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (float value)
		{
			if (id_appendln_F == IntPtr.Zero)
				id_appendln_F = JNIEnv.GetMethodID (class_ref, "appendln", "(F)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(F)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_I;
#pragma warning disable 0169
		static Delegate GetAppendln_IHandler ()
		{
			if (cb_appendln_I == null)
				cb_appendln_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Appendln_I);
			return cb_appendln_I;
		}

		static IntPtr n_Appendln_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (value));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("appendln", "(I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (int value)
		{
			if (id_appendln_I == IntPtr.Zero)
				id_appendln_I = JNIEnv.GetMethodID (class_ref, "appendln", "(I)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_Object_Handler ()
		{
			if (cb_appendln_Ljava_lang_Object_ == null)
				cb_appendln_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_Ljava_lang_Object_);
			return cb_appendln_Ljava_lang_Object_;
		}

		static IntPtr n_Appendln_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("appendln", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Java.Lang.Object obj)
		{
			if (id_appendln_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendln_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_String_Handler ()
		{
			if (cb_appendln_Ljava_lang_String_ == null)
				cb_appendln_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_Ljava_lang_String_);
			return cb_appendln_Ljava_lang_String_;
		}

		static IntPtr n_Appendln_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("appendln", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (string str)
		{
			if (id_appendln_Ljava_lang_String_ == IntPtr.Zero)
				id_appendln_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_appendln_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_String_IIHandler ()
		{
			if (cb_appendln_Ljava_lang_String_II == null)
				cb_appendln_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Appendln_Ljava_lang_String_II);
			return cb_appendln_Ljava_lang_String_II;
		}

		static IntPtr n_Appendln_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("appendln", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (string str, int startIndex, int length)
		{
			if (id_appendln_Ljava_lang_String_II == IntPtr.Zero)
				id_appendln_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/String;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_appendln_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_appendln_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_appendln_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Appendln_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_appendln_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_Appendln_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_objs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var objs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_objs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (format, objs));
			if (objs != null)
				JNIEnv.CopyArray (objs, native_objs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("appendln", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (string format, params global::Java.Lang.Object[] objs)
		{
			if (id_appendln_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_appendln_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_objs = JNIEnv.NewArray (objs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_format);
				__args [1] = new JValue (native_objs);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (objs != null) {
					JNIEnv.CopyArray (native_objs, objs);
					JNIEnv.DeleteLocalRef (native_objs);
				}
			}
		}

		static Delegate cb_appendln_Ljava_lang_StringBuffer_;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_StringBuffer_Handler ()
		{
			if (cb_appendln_Ljava_lang_StringBuffer_ == null)
				cb_appendln_Ljava_lang_StringBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_Ljava_lang_StringBuffer_);
			return cb_appendln_Ljava_lang_StringBuffer_;
		}

		static IntPtr n_Appendln_Ljava_lang_StringBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_StringBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuffer']]"
		[Register ("appendln", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_StringBuffer_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Java.Lang.StringBuffer str)
		{
			if (id_appendln_Ljava_lang_StringBuffer_ == IntPtr.Zero)
				id_appendln_Ljava_lang_StringBuffer_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_StringBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/StringBuffer;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_Ljava_lang_StringBuffer_II;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_StringBuffer_IIHandler ()
		{
			if (cb_appendln_Ljava_lang_StringBuffer_II == null)
				cb_appendln_Ljava_lang_StringBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Appendln_Ljava_lang_StringBuffer_II);
			return cb_appendln_Ljava_lang_StringBuffer_II;
		}

		static IntPtr n_Appendln_Ljava_lang_StringBuffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_StringBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("appendln", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_StringBuffer_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Java.Lang.StringBuffer str, int startIndex, int length)
		{
			if (id_appendln_Ljava_lang_StringBuffer_II == IntPtr.Zero)
				id_appendln_Ljava_lang_StringBuffer_II = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_StringBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/StringBuffer;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_Ljava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_StringBuilder_Handler ()
		{
			if (cb_appendln_Ljava_lang_StringBuilder_ == null)
				cb_appendln_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_Ljava_lang_StringBuilder_);
			return cb_appendln_Ljava_lang_StringBuilder_;
		}

		static IntPtr n_Appendln_Ljava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register ("appendln", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_StringBuilder_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Java.Lang.StringBuilder str)
		{
			if (id_appendln_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_appendln_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_StringBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/StringBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_Ljava_lang_StringBuilder_II;
#pragma warning disable 0169
		static Delegate GetAppendln_Ljava_lang_StringBuilder_IIHandler ()
		{
			if (cb_appendln_Ljava_lang_StringBuilder_II == null)
				cb_appendln_Ljava_lang_StringBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Appendln_Ljava_lang_StringBuilder_II);
			return cb_appendln_Ljava_lang_StringBuilder_II;
		}

		static IntPtr n_Appendln_Ljava_lang_StringBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Ljava_lang_StringBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("appendln", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Ljava_lang_StringBuilder_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Java.Lang.StringBuilder str, int startIndex, int length)
		{
			if (id_appendln_Ljava_lang_StringBuilder_II == IntPtr.Zero)
				id_appendln_Ljava_lang_StringBuilder_II = JNIEnv.GetMethodID (class_ref, "appendln", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Ljava_lang_StringBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Ljava/lang/StringBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_J;
#pragma warning disable 0169
		static Delegate GetAppendln_JHandler ()
		{
			if (cb_appendln_J == null)
				cb_appendln_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Appendln_J);
			return cb_appendln_J;
		}

		static IntPtr n_Appendln_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Appendln (value));
		}
#pragma warning restore 0169

		static IntPtr id_appendln_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("appendln", "(J)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_JHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (long value)
		{
			if (id_appendln_J == IntPtr.Zero)
				id_appendln_J = JNIEnv.GetMethodID (class_ref, "appendln", "(J)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(J)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetAppendln_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Appendln_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static IntPtr n_Appendln_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Org.Apache.Commons.Lang3.Text.StrBuilder str)
		{
			if (id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II;
#pragma warning disable 0169
		static Delegate GetAppendln_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler ()
		{
			if (cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II == null)
				cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Appendln_Lorg_apache_commons_lang3_text_StrBuilder_II);
			return cb_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II;
		}

		static IntPtr n_Appendln_Lorg_apache_commons_lang3_text_StrBuilder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Appendln (str, startIndex, length));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='appendln' and count(parameter)=3 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetAppendln_Lorg_apache_commons_lang3_text_StrBuilder_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Appendln (global::Org.Apache.Commons.Lang3.Text.StrBuilder str, int startIndex, int length)
		{
			if (id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II == IntPtr.Zero)
				id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II = JNIEnv.GetMethodID (class_ref, "appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (str);
				__args [1] = new JValue (startIndex);
				__args [2] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appendln_Lorg_apache_commons_lang3_text_StrBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendln", "(Lorg/apache/commons/lang3/text/StrBuilder;II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_asReader;
#pragma warning disable 0169
		static Delegate GetAsReaderHandler ()
		{
			if (cb_asReader == null)
				cb_asReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsReader);
			return cb_asReader;
		}

		static IntPtr n_AsReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsReader ());
		}
#pragma warning restore 0169

		static IntPtr id_asReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='asReader' and count(parameter)=0]"
		[Register ("asReader", "()Ljava/io/Reader;", "GetAsReaderHandler")]
		public virtual unsafe global::Java.IO.Reader AsReader ()
		{
			if (id_asReader == IntPtr.Zero)
				id_asReader = JNIEnv.GetMethodID (class_ref, "asReader", "()Ljava/io/Reader;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asReader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.IO.Reader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asReader", "()Ljava/io/Reader;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asTokenizer;
#pragma warning disable 0169
		static Delegate GetAsTokenizerHandler ()
		{
			if (cb_asTokenizer == null)
				cb_asTokenizer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsTokenizer);
			return cb_asTokenizer;
		}

		static IntPtr n_AsTokenizer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsTokenizer ());
		}
#pragma warning restore 0169

		static IntPtr id_asTokenizer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='asTokenizer' and count(parameter)=0]"
		[Register ("asTokenizer", "()Lorg/apache/commons/lang3/text/StrTokenizer;", "GetAsTokenizerHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrTokenizer AsTokenizer ()
		{
			if (id_asTokenizer == IntPtr.Zero)
				id_asTokenizer = JNIEnv.GetMethodID (class_ref, "asTokenizer", "()Lorg/apache/commons/lang3/text/StrTokenizer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asTokenizer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrTokenizer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asTokenizer", "()Lorg/apache/commons/lang3/text/StrTokenizer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_asWriter;
#pragma warning disable 0169
		static Delegate GetAsWriterHandler ()
		{
			if (cb_asWriter == null)
				cb_asWriter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsWriter);
			return cb_asWriter;
		}

		static IntPtr n_AsWriter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsWriter ());
		}
#pragma warning restore 0169

		static IntPtr id_asWriter;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='asWriter' and count(parameter)=0]"
		[Register ("asWriter", "()Ljava/io/Writer;", "GetAsWriterHandler")]
		public virtual unsafe global::Java.IO.Writer AsWriter ()
		{
			if (id_asWriter == IntPtr.Zero)
				id_asWriter = JNIEnv.GetMethodID (class_ref, "asWriter", "()Ljava/io/Writer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asWriter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asWriter", "()Ljava/io/Writer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/String;", "GetBuildHandler")]
		public virtual unsafe string Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_capacity;
#pragma warning disable 0169
		static Delegate GetCapacityHandler ()
		{
			if (cb_capacity == null)
				cb_capacity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Capacity);
			return cb_capacity;
		}

		static int n_Capacity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Capacity ();
		}
#pragma warning restore 0169

		static IntPtr id_capacity;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()I", "GetCapacityHandler")]
		public virtual unsafe int Capacity ()
		{
			if (id_capacity == IntPtr.Zero)
				id_capacity = JNIEnv.GetMethodID (class_ref, "capacity", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_capacity);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "capacity", "()I"));
			} finally {
			}
		}

		static Delegate cb_charAt_I;
#pragma warning disable 0169
		static Delegate GetCharAt_IHandler ()
		{
			if (cb_charAt_I == null)
				cb_charAt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_C) n_CharAt_I);
			return cb_charAt_I;
		}

		static char n_CharAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CharAt (index);
		}
#pragma warning restore 0169

		static IntPtr id_charAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='charAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("charAt", "(I)C", "GetCharAt_IHandler")]
		public virtual unsafe char CharAt (int index)
		{
			if (id_charAt_I == IntPtr.Zero)
				id_charAt_I = JNIEnv.GetMethodID (class_ref, "charAt", "(I)C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallCharMethod (((global::Java.Lang.Object) this).Handle, id_charAt_I, __args);
				else
					return JNIEnv.CallNonvirtualCharMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charAt", "(I)C"), __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetClearHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clear), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_contains_C;
#pragma warning disable 0169
		static Delegate GetContains_CHandler ()
		{
			if (cb_contains_C == null)
				cb_contains_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_Z) n_Contains_C);
			return cb_contains_C;
		}

		static bool n_Contains_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Contains (ch);
		}
#pragma warning restore 0169

		static IntPtr id_contains_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("contains", "(C)Z", "GetContains_CHandler")]
		public virtual unsafe bool Contains (char ch)
		{
			if (id_contains_C == IntPtr.Zero)
				id_contains_C = JNIEnv.GetMethodID (class_ref, "contains", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_C, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(C)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (str);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
		public virtual unsafe bool Contains (string str)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_contains_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_contains_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_contains_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_contains_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static bool n_Contains_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (matcher);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("contains", "(Lorg/apache/commons/lang3/text/StrMatcher;)Z", "GetContains_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe bool Contains (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher)
		{
			if (id_contains_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_contains_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/apache/commons/lang3/text/StrMatcher;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (matcher);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lorg/apache/commons/lang3/text/StrMatcher;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_delete_II;
#pragma warning disable 0169
		static Delegate GetDelete_IIHandler ()
		{
			if (cb_delete_II == null)
				cb_delete_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Delete_II);
			return cb_delete_II;
		}

		static IntPtr n_Delete_II (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Delete (startIndex, endIndex));
		}
#pragma warning restore 0169

		static IntPtr id_delete_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("delete", "(II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDelete_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Delete (int startIndex, int endIndex)
		{
			if (id_delete_II == IntPtr.Zero)
				id_delete_II = JNIEnv.GetMethodID (class_ref, "delete", "(II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteAll_C;
#pragma warning disable 0169
		static Delegate GetDeleteAll_CHandler ()
		{
			if (cb_deleteAll_C == null)
				cb_deleteAll_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_DeleteAll_C);
			return cb_deleteAll_C;
		}

		static IntPtr n_DeleteAll_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeleteAll (ch));
		}
#pragma warning restore 0169

		static IntPtr id_deleteAll_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("deleteAll", "(C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteAll_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteAll (char ch)
		{
			if (id_deleteAll_C == IntPtr.Zero)
				id_deleteAll_C = JNIEnv.GetMethodID (class_ref, "deleteAll", "(C)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAll", "(C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAll_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAll_Ljava_lang_String_ == null)
				cb_deleteAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeleteAll_Ljava_lang_String_);
			return cb_deleteAll_Ljava_lang_String_;
		}

		static IntPtr n_DeleteAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteAll (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteAll_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAll", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteAll_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteAll (string str)
		{
			if (id_deleteAll_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAll", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAll", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetDeleteAll_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeleteAll_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_DeleteAll_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteAll (matcher));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("deleteAll", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteAll_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteAll (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher)
		{
			if (id_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "deleteAll", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (matcher);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAll", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteCharAt_I;
#pragma warning disable 0169
		static Delegate GetDeleteCharAt_IHandler ()
		{
			if (cb_deleteCharAt_I == null)
				cb_deleteCharAt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_DeleteCharAt_I);
			return cb_deleteCharAt_I;
		}

		static IntPtr n_DeleteCharAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeleteCharAt (index));
		}
#pragma warning restore 0169

		static IntPtr id_deleteCharAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteCharAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deleteCharAt", "(I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteCharAt_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteCharAt (int index)
		{
			if (id_deleteCharAt_I == IntPtr.Zero)
				id_deleteCharAt_I = JNIEnv.GetMethodID (class_ref, "deleteCharAt", "(I)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteCharAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteCharAt", "(I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteFirst_C;
#pragma warning disable 0169
		static Delegate GetDeleteFirst_CHandler ()
		{
			if (cb_deleteFirst_C == null)
				cb_deleteFirst_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_L) n_DeleteFirst_C);
			return cb_deleteFirst_C;
		}

		static IntPtr n_DeleteFirst_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeleteFirst (ch));
		}
#pragma warning restore 0169

		static IntPtr id_deleteFirst_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteFirst' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("deleteFirst", "(C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteFirst_CHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteFirst (char ch)
		{
			if (id_deleteFirst_C == IntPtr.Zero)
				id_deleteFirst_C = JNIEnv.GetMethodID (class_ref, "deleteFirst", "(C)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteFirst_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFirst", "(C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteFirst_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFirst_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFirst_Ljava_lang_String_ == null)
				cb_deleteFirst_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeleteFirst_Ljava_lang_String_);
			return cb_deleteFirst_Ljava_lang_String_;
		}

		static IntPtr n_DeleteFirst_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteFirst (str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteFirst_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteFirst' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFirst", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteFirst_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteFirst (string str)
		{
			if (id_deleteFirst_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteFirst_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteFirst", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteFirst_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFirst", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetDeleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DeleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static IntPtr n_DeleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteFirst (matcher));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='deleteFirst' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("deleteFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetDeleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder DeleteFirst (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher)
		{
			if (id_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "deleteFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (matcher);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteFirst_Lorg_apache_commons_lang3_text_StrMatcher_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_endsWith_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEndsWith_Ljava_lang_String_Handler ()
		{
			if (cb_endsWith_Ljava_lang_String_ == null)
				cb_endsWith_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_EndsWith_Ljava_lang_String_);
			return cb_endsWith_Ljava_lang_String_;
		}

		static bool n_EndsWith_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EndsWith (str);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_endsWith_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='endsWith' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("endsWith", "(Ljava/lang/String;)Z", "GetEndsWith_Ljava_lang_String_Handler")]
		public virtual unsafe bool EndsWith (string str)
		{
			if (id_endsWith_Ljava_lang_String_ == IntPtr.Zero)
				id_endsWith_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "endsWith", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_endsWith_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endsWith", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_ensureCapacity_I;
#pragma warning disable 0169
		static Delegate GetEnsureCapacity_IHandler ()
		{
			if (cb_ensureCapacity_I == null)
				cb_ensureCapacity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_EnsureCapacity_I);
			return cb_ensureCapacity_I;
		}

		static IntPtr n_EnsureCapacity_I (IntPtr jnienv, IntPtr native__this, int capacity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnsureCapacity (capacity));
		}
#pragma warning restore 0169

		static IntPtr id_ensureCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='ensureCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ensureCapacity", "(I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetEnsureCapacity_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder EnsureCapacity (int capacity)
		{
			if (id_ensureCapacity_I == IntPtr.Zero)
				id_ensureCapacity_I = JNIEnv.GetMethodID (class_ref, "ensureCapacity", "(I)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ensureCapacity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ensureCapacity", "(I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_equals_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_equals_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_equals_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_equals_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static bool n_Equals_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("equals", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z", "GetEquals_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe bool Equals (global::Org.Apache.Commons.Lang3.Text.StrBuilder other)
		{
			if (id_equals_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_equals_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lorg_apache_commons_lang3_text_StrBuilder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_;
#pragma warning disable 0169
		static Delegate GetEqualsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_Handler ()
		{
			if (cb_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_ == null)
				cb_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_EqualsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_);
			return cb_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_;
		}

		static bool n_EqualsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsIgnoreCase (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='equalsIgnoreCase' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrBuilder']]"
		[Register ("equalsIgnoreCase", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z", "GetEqualsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_Handler")]
		public virtual unsafe bool EqualsIgnoreCase (global::Org.Apache.Commons.Lang3.Text.StrBuilder other)
		{
			if (id_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_ == IntPtr.Zero)
				id_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_ = JNIEnv.GetMethodID (class_ref, "equalsIgnoreCase", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalsIgnoreCase_Lorg_apache_commons_lang3_text_StrBuilder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equalsIgnoreCase", "(Lorg/apache/commons/lang3/text/StrBuilder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChars_arrayC;
#pragma warning disable 0169
		static Delegate GetGetChars_arrayCHandler ()
		{
			if (cb_getChars_arrayC == null)
				cb_getChars_arrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetChars_arrayC);
			return cb_getChars_arrayC;
		}

		static IntPtr n_GetChars_arrayC (IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destination = (char[]) JNIEnv.GetArray (native_destination, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.NewArray (__this.GetChars (destination));
			if (destination != null)
				JNIEnv.CopyArray (destination, native_destination);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChars_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='getChars' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("getChars", "([C)[C", "GetGetChars_arrayCHandler")]
		public virtual unsafe char[] GetChars (char[] destination)
		{
			if (id_getChars_arrayC == IntPtr.Zero)
				id_getChars_arrayC = JNIEnv.GetMethodID (class_ref, "getChars", "([C)[C");
			IntPtr native_destination = JNIEnv.NewArray (destination);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_destination);

				char[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChars_arrayC, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					__ret = (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChars", "([C)[C"), __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (destination != null) {
					JNIEnv.CopyArray (native_destination, destination);
					JNIEnv.DeleteLocalRef (native_destination);
				}
			}
		}

		static Delegate cb_getChars_IIarrayCI;
#pragma warning disable 0169
		static Delegate GetGetChars_IIarrayCIHandler ()
		{
			if (cb_getChars_IIarrayCI == null)
				cb_getChars_IIarrayCI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILI_V) n_GetChars_IIarrayCI);
			return cb_getChars_IIarrayCI;
		}

		static void n_GetChars_IIarrayCI (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex, IntPtr native_destination, int destinationIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destination = (char[]) JNIEnv.GetArray (native_destination, JniHandleOwnership.DoNotTransfer, typeof (char));
			__this.GetChars (startIndex, endIndex, destination, destinationIndex);
			if (destination != null)
				JNIEnv.CopyArray (destination, native_destination);
		}
#pragma warning restore 0169

		static IntPtr id_getChars_IIarrayCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='getChars' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='char[]'] and parameter[4][@type='int']]"
		[Register ("getChars", "(II[CI)V", "GetGetChars_IIarrayCIHandler")]
		public virtual unsafe void GetChars (int startIndex, int endIndex, char[] destination, int destinationIndex)
		{
			if (id_getChars_IIarrayCI == IntPtr.Zero)
				id_getChars_IIarrayCI = JNIEnv.GetMethodID (class_ref, "getChars", "(II[CI)V");
			IntPtr native_destination = JNIEnv.NewArray (destination);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);
				__args [2] = new JValue (native_destination);
				__args [3] = new JValue (destinationIndex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getChars_IIarrayCI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChars", "(II[CI)V"), __args);
			} finally {
				if (destination != null) {
					JNIEnv.CopyArray (native_destination, destination);
					JNIEnv.DeleteLocalRef (native_destination);
				}
			}
		}

		static Delegate cb_indexOf_C;
#pragma warning disable 0169
		static Delegate GetIndexOf_CHandler ()
		{
			if (cb_indexOf_C == null)
				cb_indexOf_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_I) n_IndexOf_C);
			return cb_indexOf_C;
		}

		static int n_IndexOf_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (ch);
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("indexOf", "(C)I", "GetIndexOf_CHandler")]
		public virtual unsafe int IndexOf (char ch)
		{
			if (id_indexOf_C == IntPtr.Zero)
				id_indexOf_C = JNIEnv.GetMethodID (class_ref, "indexOf", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_C, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(C)I"), __args);
			} finally {
			}
		}

		static Delegate cb_indexOf_CI;
#pragma warning disable 0169
		static Delegate GetIndexOf_CIHandler ()
		{
			if (cb_indexOf_CI == null)
				cb_indexOf_CI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCI_I) n_IndexOf_CI);
			return cb_indexOf_CI;
		}

		static int n_IndexOf_CI (IntPtr jnienv, IntPtr native__this, char ch, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexOf (ch, startIndex);
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(CI)I", "GetIndexOf_CIHandler")]
		public virtual unsafe int IndexOf (char ch, int startIndex)
		{
			if (id_indexOf_CI == IntPtr.Zero)
				id_indexOf_CI = JNIEnv.GetMethodID (class_ref, "indexOf", "(CI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (startIndex);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_CI, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(CI)I"), __args);
			} finally {
			}
		}

		static Delegate cb_indexOf_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Ljava_lang_String_Handler ()
		{
			if (cb_indexOf_Ljava_lang_String_ == null)
				cb_indexOf_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IndexOf_Ljava_lang_String_);
			return cb_indexOf_Ljava_lang_String_;
		}

		static int n_IndexOf_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (str);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("indexOf", "(Ljava/lang/String;)I", "GetIndexOf_Ljava_lang_String_Handler")]
		public virtual unsafe int IndexOf (string str)
		{
			if (id_indexOf_Ljava_lang_String_ == IntPtr.Zero)
				id_indexOf_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Ljava/lang/String;)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_indexOf_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetIndexOf_Ljava_lang_String_IHandler ()
		{
			if (cb_indexOf_Ljava_lang_String_I == null)
				cb_indexOf_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IndexOf_Ljava_lang_String_I);
			return cb_indexOf_Ljava_lang_String_I;
		}

		static int n_IndexOf_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (str, startIndex);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(Ljava/lang/String;I)I", "GetIndexOf_Ljava_lang_String_IHandler")]
		public virtual unsafe int IndexOf (string str, int startIndex)
		{
			if (id_indexOf_Ljava_lang_String_I == IntPtr.Zero)
				id_indexOf_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "indexOf", "(Ljava/lang/String;I)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (startIndex);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Ljava/lang/String;I)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IndexOf_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static int n_IndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (matcher);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I", "GetIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe int IndexOf (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher)
		{
			if (id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (matcher);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_IHandler ()
		{
			if (cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I == null)
				cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I);
			return cb_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
		}

		static int n_IndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (matcher, startIndex);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[2][@type='int']]"
		[Register ("indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I", "GetIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_IHandler")]
		public virtual unsafe int IndexOf (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher, int startIndex)
		{
			if (id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I == IntPtr.Zero)
				id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (matcher);
				__args [1] = new JValue (startIndex);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lorg_apache_commons_lang3_text_StrMatcher_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insert_IZ;
#pragma warning disable 0169
		static Delegate GetInsert_IZHandler ()
		{
			if (cb_insert_IZ == null)
				cb_insert_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_L) n_Insert_IZ);
			return cb_insert_IZ;
		}

		static IntPtr n_Insert_IZ (IntPtr jnienv, IntPtr native__this, int index, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("insert", "(IZ)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IZHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, bool value)
		{
			if (id_insert_IZ == IntPtr.Zero)
				id_insert_IZ = JNIEnv.GetMethodID (class_ref, "insert", "(IZ)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(IZ)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_IC;
#pragma warning disable 0169
		static Delegate GetInsert_ICHandler ()
		{
			if (cb_insert_IC == null)
				cb_insert_IC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIC_L) n_Insert_IC);
			return cb_insert_IC;
		}

		static IntPtr n_Insert_IC (IntPtr jnienv, IntPtr native__this, int index, char value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='char']]"
		[Register ("insert", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_ICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, char value)
		{
			if (id_insert_IC == IntPtr.Zero)
				id_insert_IC = JNIEnv.GetMethodID (class_ref, "insert", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_IarrayC;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayCHandler ()
		{
			if (cb_insert_IarrayC == null)
				cb_insert_IarrayC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Insert_IarrayC);
			return cb_insert_IarrayC;
		}

		static IntPtr n_Insert_IarrayC (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_chars)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (index, chars));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_IarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='char[]']]"
		[Register ("insert", "(I[C)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IarrayCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, char[] chars)
		{
			if (id_insert_IarrayC == IntPtr.Zero)
				id_insert_IarrayC = JNIEnv.GetMethodID (class_ref, "insert", "(I[C)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_chars);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IarrayC, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(I[C)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_insert_IarrayCII;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayCIIHandler ()
		{
			if (cb_insert_IarrayCII == null)
				cb_insert_IarrayCII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILII_L) n_Insert_IarrayCII);
			return cb_insert_IarrayCII;
		}

		static IntPtr n_Insert_IarrayCII (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_chars, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chars = (char[]) JNIEnv.GetArray (native_chars, JniHandleOwnership.DoNotTransfer, typeof (char));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (index, chars, offset, length));
			if (chars != null)
				JNIEnv.CopyArray (chars, native_chars);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_IarrayCII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='char[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("insert", "(I[CII)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IarrayCIIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, char[] chars, int offset, int length)
		{
			if (id_insert_IarrayCII == IntPtr.Zero)
				id_insert_IarrayCII = JNIEnv.GetMethodID (class_ref, "insert", "(I[CII)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_chars = JNIEnv.NewArray (chars);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_chars);
				__args [2] = new JValue (offset);
				__args [3] = new JValue (length);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IarrayCII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(I[CII)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (chars != null) {
					JNIEnv.CopyArray (native_chars, chars);
					JNIEnv.DeleteLocalRef (native_chars);
				}
			}
		}

		static Delegate cb_insert_ID;
#pragma warning disable 0169
		static Delegate GetInsert_IDHandler ()
		{
			if (cb_insert_ID == null)
				cb_insert_ID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPID_L) n_Insert_ID);
			return cb_insert_ID;
		}

		static IntPtr n_Insert_ID (IntPtr jnienv, IntPtr native__this, int index, double value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("insert", "(ID)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IDHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, double value)
		{
			if (id_insert_ID == IntPtr.Zero)
				id_insert_ID = JNIEnv.GetMethodID (class_ref, "insert", "(ID)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_ID, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ID)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_IF;
#pragma warning disable 0169
		static Delegate GetInsert_IFHandler ()
		{
			if (cb_insert_IF == null)
				cb_insert_IF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIF_L) n_Insert_IF);
			return cb_insert_IF;
		}

		static IntPtr n_Insert_IF (IntPtr jnienv, IntPtr native__this, int index, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("insert", "(IF)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IFHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, float value)
		{
			if (id_insert_IF == IntPtr.Zero)
				id_insert_IF = JNIEnv.GetMethodID (class_ref, "insert", "(IF)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(IF)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_II;
#pragma warning disable 0169
		static Delegate GetInsert_IIHandler ()
		{
			if (cb_insert_II == null)
				cb_insert_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Insert_II);
			return cb_insert_II;
		}

		static IntPtr n_Insert_II (IntPtr jnienv, IntPtr native__this, int index, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("insert", "(II)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, int value)
		{
			if (id_insert_II == IntPtr.Zero)
				id_insert_II = JNIEnv.GetMethodID (class_ref, "insert", "(II)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(II)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_insert_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_Object_Handler ()
		{
			if (cb_insert_ILjava_lang_Object_ == null)
				cb_insert_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Insert_ILjava_lang_Object_);
			return cb_insert_ILjava_lang_Object_;
		}

		static IntPtr n_Insert_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (index, obj));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("insert", "(ILjava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_ILjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, global::Java.Lang.Object obj)
		{
			if (id_insert_ILjava_lang_Object_ == IntPtr.Zero)
				id_insert_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (obj);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/Object;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insert_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_String_Handler ()
		{
			if (cb_insert_ILjava_lang_String_ == null)
				cb_insert_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Insert_ILjava_lang_String_);
			return cb_insert_ILjava_lang_String_;
		}

		static IntPtr n_Insert_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (index, str));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("insert", "(ILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_ILjava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, string str)
		{
			if (id_insert_ILjava_lang_String_ == IntPtr.Zero)
				id_insert_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_str);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_insert_IJ;
#pragma warning disable 0169
		static Delegate GetInsert_IJHandler ()
		{
			if (cb_insert_IJ == null)
				cb_insert_IJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJ_L) n_Insert_IJ);
			return cb_insert_IJ;
		}

		static IntPtr n_Insert_IJ (IntPtr jnienv, IntPtr native__this, int index, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Insert (index, value));
		}
#pragma warning restore 0169

		static IntPtr id_insert_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("insert", "(IJ)Lorg/apache/commons/lang3/text/StrBuilder;", "GetInsert_IJHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Insert (int index, long value)
		{
			if (id_insert_IJ == IntPtr.Zero)
				id_insert_IJ = JNIEnv.GetMethodID (class_ref, "insert", "(IJ)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_IJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(IJ)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_lastIndexOf_C;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_CHandler ()
		{
			if (cb_lastIndexOf_C == null)
				cb_lastIndexOf_C = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPC_I) n_LastIndexOf_C);
			return cb_lastIndexOf_C;
		}

		static int n_LastIndexOf_C (IntPtr jnienv, IntPtr native__this, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastIndexOf (ch);
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("lastIndexOf", "(C)I", "GetLastIndexOf_CHandler")]
		public virtual unsafe int LastIndexOf (char ch)
		{
			if (id_lastIndexOf_C == IntPtr.Zero)
				id_lastIndexOf_C = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(C)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_C, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(C)I"), __args);
			} finally {
			}
		}

		static Delegate cb_lastIndexOf_CI;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_CIHandler ()
		{
			if (cb_lastIndexOf_CI == null)
				cb_lastIndexOf_CI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCI_I) n_LastIndexOf_CI);
			return cb_lastIndexOf_CI;
		}

		static int n_LastIndexOf_CI (IntPtr jnienv, IntPtr native__this, char ch, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastIndexOf (ch, startIndex);
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(CI)I", "GetLastIndexOf_CIHandler")]
		public virtual unsafe int LastIndexOf (char ch, int startIndex)
		{
			if (id_lastIndexOf_CI == IntPtr.Zero)
				id_lastIndexOf_CI = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(CI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ch);
				__args [1] = new JValue (startIndex);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_CI, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(CI)I"), __args);
			} finally {
			}
		}

		static Delegate cb_lastIndexOf_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Ljava_lang_String_Handler ()
		{
			if (cb_lastIndexOf_Ljava_lang_String_ == null)
				cb_lastIndexOf_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_LastIndexOf_Ljava_lang_String_);
			return cb_lastIndexOf_Ljava_lang_String_;
		}

		static int n_LastIndexOf_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (str);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lastIndexOf", "(Ljava/lang/String;)I", "GetLastIndexOf_Ljava_lang_String_Handler")]
		public virtual unsafe int LastIndexOf (string str)
		{
			if (id_lastIndexOf_Ljava_lang_String_ == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Ljava/lang/String;)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_lastIndexOf_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Ljava_lang_String_IHandler ()
		{
			if (cb_lastIndexOf_Ljava_lang_String_I == null)
				cb_lastIndexOf_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_LastIndexOf_Ljava_lang_String_I);
			return cb_lastIndexOf_Ljava_lang_String_I;
		}

		static int n_LastIndexOf_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_str, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (str, startIndex);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(Ljava/lang/String;I)I", "GetLastIndexOf_Ljava_lang_String_IHandler")]
		public virtual unsafe int LastIndexOf (string str, int startIndex)
		{
			if (id_lastIndexOf_Ljava_lang_String_I == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Ljava/lang/String;I)I");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (startIndex);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(Ljava/lang/String;I)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_Handler ()
		{
			if (cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ == null)
				cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_LastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_);
			return cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
		}

		static int n_LastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (matcher);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher']]"
		[Register ("lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I", "GetLastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_Handler")]
		public virtual unsafe int LastIndexOf (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher)
		{
			if (id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ == IntPtr.Zero)
				id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_ = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (matcher);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_IHandler ()
		{
			if (cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I == null)
				cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_LastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I);
			return cb_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
		}

		static int n_LastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher, int startIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (matcher, startIndex);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='lastIndexOf' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[2][@type='int']]"
		[Register ("lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I", "GetLastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_IHandler")]
		public virtual unsafe int LastIndexOf (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher, int startIndex)
		{
			if (id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I == IntPtr.Zero)
				id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (matcher);
				__args [1] = new JValue (startIndex);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lastIndexOf_Lorg_apache_commons_lang3_text_StrMatcher_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(Lorg/apache/commons/lang3/text/StrMatcher;I)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_leftString_I;
#pragma warning disable 0169
		static Delegate GetLeftString_IHandler ()
		{
			if (cb_leftString_I == null)
				cb_leftString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_LeftString_I);
			return cb_leftString_I;
		}

		static IntPtr n_LeftString_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LeftString (length));
		}
#pragma warning restore 0169

		static IntPtr id_leftString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='leftString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leftString", "(I)Ljava/lang/String;", "GetLeftString_IHandler")]
		public virtual unsafe string LeftString (int length)
		{
			if (id_leftString_I == IntPtr.Zero)
				id_leftString_I = JNIEnv.GetMethodID (class_ref, "leftString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (length);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leftString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leftString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public virtual unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
			}
		}

		static Delegate cb_midString_II;
#pragma warning disable 0169
		static Delegate GetMidString_IIHandler ()
		{
			if (cb_midString_II == null)
				cb_midString_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_MidString_II);
			return cb_midString_II;
		}

		static IntPtr n_MidString_II (IntPtr jnienv, IntPtr native__this, int index, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MidString (index, length));
		}
#pragma warning restore 0169

		static IntPtr id_midString_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='midString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("midString", "(II)Ljava/lang/String;", "GetMidString_IIHandler")]
		public virtual unsafe string MidString (int index, int length)
		{
			if (id_midString_II == IntPtr.Zero)
				id_midString_II = JNIEnv.GetMethodID (class_ref, "midString", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (length);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_midString_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "midString", "(II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_minimizeCapacity;
#pragma warning disable 0169
		static Delegate GetMinimizeCapacityHandler ()
		{
			if (cb_minimizeCapacity == null)
				cb_minimizeCapacity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MinimizeCapacity);
			return cb_minimizeCapacity;
		}

		static IntPtr n_MinimizeCapacity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinimizeCapacity ());
		}
#pragma warning restore 0169

		static IntPtr id_minimizeCapacity;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='minimizeCapacity' and count(parameter)=0]"
		[Register ("minimizeCapacity", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetMinimizeCapacityHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder MinimizeCapacity ()
		{
			if (id_minimizeCapacity == IntPtr.Zero)
				id_minimizeCapacity = JNIEnv.GetMethodID (class_ref, "minimizeCapacity", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minimizeCapacity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minimizeCapacity", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readFrom_Ljava_lang_Readable_;
#pragma warning disable 0169
		static Delegate GetReadFrom_Ljava_lang_Readable_Handler ()
		{
			if (cb_readFrom_Ljava_lang_Readable_ == null)
				cb_readFrom_Ljava_lang_Readable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ReadFrom_Ljava_lang_Readable_);
			return cb_readFrom_Ljava_lang_Readable_;
		}

		static int n_ReadFrom_Ljava_lang_Readable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_readable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var readable = (global::Java.Lang.IReadable)global::Java.Lang.Object.GetObject<global::Java.Lang.IReadable> (native_readable, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadFrom (readable);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readFrom_Ljava_lang_Readable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='java.lang.Readable']]"
		[Register ("readFrom", "(Ljava/lang/Readable;)I", "GetReadFrom_Ljava_lang_Readable_Handler")]
		public virtual unsafe int ReadFrom (global::Java.Lang.IReadable readable)
		{
			if (id_readFrom_Ljava_lang_Readable_ == IntPtr.Zero)
				id_readFrom_Ljava_lang_Readable_ = JNIEnv.GetMethodID (class_ref, "readFrom", "(Ljava/lang/Readable;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (readable);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFrom_Ljava_lang_Readable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFrom", "(Ljava/lang/Readable;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_replace_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplace_IILjava_lang_String_Handler ()
		{
			if (cb_replace_IILjava_lang_String_ == null)
				cb_replace_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_L) n_Replace_IILjava_lang_String_);
			return cb_replace_IILjava_lang_String_;
		}

		static IntPtr n_Replace_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex, IntPtr native_replaceStr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Replace (startIndex, endIndex, replaceStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("replace", "(IILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplace_IILjava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Replace (int startIndex, int endIndex, string replaceStr)
		{
			if (id_replace_IILjava_lang_String_ == IntPtr.Zero)
				id_replace_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replace", "(IILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);
				__args [2] = new JValue (native_replaceStr);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_IILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(IILjava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetReplace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_IIIHandler ()
		{
			if (cb_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III == null)
				cb_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIII_L) n_Replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III);
			return cb_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III;
		}

		static IntPtr n_Replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher, IntPtr native_replaceStr, int startIndex, int endIndex, int replaceCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Replace (matcher, replaceStr, startIndex, endIndex, replaceCount));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replace' and count(parameter)=5 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("replace", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;III)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_IIIHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Replace (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher, string replaceStr, int startIndex, int endIndex, int replaceCount)
		{
			if (id_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III == IntPtr.Zero)
				id_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "replace", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;III)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (matcher);
				__args [1] = new JValue (native_replaceStr);
				__args [2] = new JValue (startIndex);
				__args [3] = new JValue (endIndex);
				__args [4] = new JValue (replaceCount);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replace_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_III, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;III)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_replaceAll_CC;
#pragma warning disable 0169
		static Delegate GetReplaceAll_CCHandler ()
		{
			if (cb_replaceAll_CC == null)
				cb_replaceAll_CC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCC_L) n_ReplaceAll_CC);
			return cb_replaceAll_CC;
		}

		static IntPtr n_ReplaceAll_CC (IntPtr jnienv, IntPtr native__this, char search, char replace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReplaceAll (search, replace));
		}
#pragma warning restore 0169

		static IntPtr id_replaceAll_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceAll' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("replaceAll", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceAll_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceAll (char search, char replace)
		{
			if (id_replaceAll_CC == IntPtr.Zero)
				id_replaceAll_CC = JNIEnv.GetMethodID (class_ref, "replaceAll", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (search);
				__args [1] = new JValue (replace);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceAll_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceAll", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_replaceAll_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceAll_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_replaceAll_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_replaceAll_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ReplaceAll_Ljava_lang_String_Ljava_lang_String_);
			return cb_replaceAll_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ReplaceAll_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_searchStr, IntPtr native_replaceStr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var searchStr = JNIEnv.GetString (native_searchStr, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReplaceAll (searchStr, replaceStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceAll_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceAll_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceAll (string searchStr, string replaceStr)
		{
			if (id_replaceAll_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceAll_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_searchStr = JNIEnv.NewString (searchStr);
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_searchStr);
				__args [1] = new JValue (native_replaceStr);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceAll_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_searchStr);
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_Handler ()
		{
			if (cb_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ == null)
				cb_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ReplaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_);
			return cb_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
		}

		static IntPtr n_ReplaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher, IntPtr native_replaceStr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReplaceAll (matcher, replaceStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceAll' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceAll", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceAll (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher, string replaceStr)
		{
			if (id_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceAll", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (matcher);
				__args [1] = new JValue (native_replaceStr);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceAll_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceAll", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_replaceFirst_CC;
#pragma warning disable 0169
		static Delegate GetReplaceFirst_CCHandler ()
		{
			if (cb_replaceFirst_CC == null)
				cb_replaceFirst_CC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPCC_L) n_ReplaceFirst_CC);
			return cb_replaceFirst_CC;
		}

		static IntPtr n_ReplaceFirst_CC (IntPtr jnienv, IntPtr native__this, char search, char replace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReplaceFirst (search, replace));
		}
#pragma warning restore 0169

		static IntPtr id_replaceFirst_CC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceFirst' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
		[Register ("replaceFirst", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceFirst_CCHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceFirst (char search, char replace)
		{
			if (id_replaceFirst_CC == IntPtr.Zero)
				id_replaceFirst_CC = JNIEnv.GetMethodID (class_ref, "replaceFirst", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (search);
				__args [1] = new JValue (replace);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceFirst_CC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFirst", "(CC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_replaceFirst_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceFirst_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_replaceFirst_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_replaceFirst_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ReplaceFirst_Ljava_lang_String_Ljava_lang_String_);
			return cb_replaceFirst_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ReplaceFirst_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_searchStr, IntPtr native_replaceStr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var searchStr = JNIEnv.GetString (native_searchStr, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReplaceFirst (searchStr, replaceStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceFirst_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceFirst' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceFirst_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceFirst (string searchStr, string replaceStr)
		{
			if (id_replaceFirst_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceFirst_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_searchStr = JNIEnv.NewString (searchStr);
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_searchStr);
				__args [1] = new JValue (native_replaceStr);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceFirst_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_searchStr);
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_Handler ()
		{
			if (cb_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ == null)
				cb_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ReplaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_);
			return cb_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
		}

		static IntPtr n_ReplaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matcher, IntPtr native_replaceStr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var matcher = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrMatcher> (native_matcher, JniHandleOwnership.DoNotTransfer);
			var replaceStr = JNIEnv.GetString (native_replaceStr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReplaceFirst (matcher, replaceStr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='replaceFirst' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.text.StrMatcher'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetReplaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder ReplaceFirst (global::Org.Apache.Commons.Lang3.Text.StrMatcher matcher, string replaceStr)
		{
			if (id_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_replaceStr = JNIEnv.NewString (replaceStr);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (matcher);
				__args [1] = new JValue (native_replaceStr);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_replaceFirst_Lorg_apache_commons_lang3_text_StrMatcher_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFirst", "(Lorg/apache/commons/lang3/text/StrMatcher;Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_replaceStr);
			}
		}

		static Delegate cb_reverse;
#pragma warning disable 0169
		static Delegate GetReverseHandler ()
		{
			if (cb_reverse == null)
				cb_reverse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Reverse);
			return cb_reverse;
		}

		static IntPtr n_Reverse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reverse ());
		}
#pragma warning restore 0169

		static IntPtr id_reverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='reverse' and count(parameter)=0]"
		[Register ("reverse", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetReverseHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Reverse ()
		{
			if (id_reverse == IntPtr.Zero)
				id_reverse = JNIEnv.GetMethodID (class_ref, "reverse", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reverse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reverse", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rightString_I;
#pragma warning disable 0169
		static Delegate GetRightString_IHandler ()
		{
			if (cb_rightString_I == null)
				cb_rightString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_RightString_I);
			return cb_rightString_I;
		}

		static IntPtr n_RightString_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RightString (length));
		}
#pragma warning restore 0169

		static IntPtr id_rightString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='rightString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("rightString", "(I)Ljava/lang/String;", "GetRightString_IHandler")]
		public virtual unsafe string RightString (int length)
		{
			if (id_rightString_I == IntPtr.Zero)
				id_rightString_I = JNIEnv.GetMethodID (class_ref, "rightString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (length);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rightString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rightString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCharAt_IC;
#pragma warning disable 0169
		static Delegate GetSetCharAt_ICHandler ()
		{
			if (cb_setCharAt_IC == null)
				cb_setCharAt_IC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIC_L) n_SetCharAt_IC);
			return cb_setCharAt_IC;
		}

		static IntPtr n_SetCharAt_IC (IntPtr jnienv, IntPtr native__this, int index, char ch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCharAt (index, ch));
		}
#pragma warning restore 0169

		static IntPtr id_setCharAt_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='setCharAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='char']]"
		[Register ("setCharAt", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;", "GetSetCharAt_ICHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder SetCharAt (int index, char ch)
		{
			if (id_setCharAt_IC == IntPtr.Zero)
				id_setCharAt_IC = JNIEnv.GetMethodID (class_ref, "setCharAt", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (ch);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCharAt_IC, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCharAt", "(IC)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLength_I;
#pragma warning disable 0169
		static Delegate GetSetLength_IHandler ()
		{
			if (cb_setLength_I == null)
				cb_setLength_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetLength_I);
			return cb_setLength_I;
		}

		static IntPtr n_SetLength_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLength (length));
		}
#pragma warning restore 0169

		static IntPtr id_setLength_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='setLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLength", "(I)Lorg/apache/commons/lang3/text/StrBuilder;", "GetSetLength_IHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder SetLength (int length)
		{
			if (id_setLength_I == IntPtr.Zero)
				id_setLength_I = JNIEnv.GetMethodID (class_ref, "setLength", "(I)Lorg/apache/commons/lang3/text/StrBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (length);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLength_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLength", "(I)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNewLineText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNewLineText_Ljava_lang_String_Handler ()
		{
			if (cb_setNewLineText_Ljava_lang_String_ == null)
				cb_setNewLineText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNewLineText_Ljava_lang_String_);
			return cb_setNewLineText_Ljava_lang_String_;
		}

		static IntPtr n_SetNewLineText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newLine = JNIEnv.GetString (native_newLine, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNewLineText (newLine));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNewLineText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='setNewLineText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNewLineText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetSetNewLineText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder SetNewLineText (string newLine)
		{
			if (id_setNewLineText_Ljava_lang_String_ == IntPtr.Zero)
				id_setNewLineText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNewLineText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_newLine = JNIEnv.NewString (newLine);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_newLine);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNewLineText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewLineText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_newLine);
			}
		}

		static Delegate cb_setNullText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNullText_Ljava_lang_String_Handler ()
		{
			if (cb_setNullText_Ljava_lang_String_ == null)
				cb_setNullText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNullText_Ljava_lang_String_);
			return cb_setNullText_Ljava_lang_String_;
		}

		static IntPtr n_SetNullText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nullText)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nullText = JNIEnv.GetString (native_nullText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNullText (nullText));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNullText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='setNullText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNullText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;", "GetSetNullText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder SetNullText (string nullText)
		{
			if (id_setNullText_Ljava_lang_String_ == IntPtr.Zero)
				id_setNullText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNullText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;");
			IntPtr native_nullText = JNIEnv.NewString (nullText);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_nullText);

				global::Org.Apache.Commons.Lang3.Text.StrBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNullText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNullText", "(Ljava/lang/String;)Lorg/apache/commons/lang3/text/StrBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_nullText);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_startsWith_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartsWith_Ljava_lang_String_Handler ()
		{
			if (cb_startsWith_Ljava_lang_String_ == null)
				cb_startsWith_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_StartsWith_Ljava_lang_String_);
			return cb_startsWith_Ljava_lang_String_;
		}

		static bool n_StartsWith_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartsWith (str);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startsWith_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='startsWith' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startsWith", "(Ljava/lang/String;)Z", "GetStartsWith_Ljava_lang_String_Handler")]
		public virtual unsafe bool StartsWith (string str)
		{
			if (id_startsWith_Ljava_lang_String_ == IntPtr.Zero)
				id_startsWith_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startsWith", "(Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startsWith_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startsWith", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_subSequence_II;
#pragma warning disable 0169
		static Delegate GetSubSequence_IIHandler ()
		{
			if (cb_subSequence_II == null)
				cb_subSequence_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_SubSequence_II);
			return cb_subSequence_II;
		}

		static IntPtr n_SubSequence_II (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.SubSequenceFormatted (startIndex, endIndex));
		}
#pragma warning restore 0169

		static IntPtr id_subSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='subSequence' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("subSequence", "(II)Ljava/lang/CharSequence;", "GetSubSequence_IIHandler")]
		public virtual unsafe global::Java.Lang.ICharSequence SubSequenceFormatted (int startIndex, int endIndex)
		{
			if (id_subSequence_II == IntPtr.Zero)
				id_subSequence_II = JNIEnv.GetMethodID (class_ref, "subSequence", "(II)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subSequence_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subSequence", "(II)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string SubSequence (int startIndex, int endIndex)
		{
			global::Java.Lang.ICharSequence __result = SubSequenceFormatted (startIndex, endIndex);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		static Delegate cb_substring_I;
#pragma warning disable 0169
		static Delegate GetSubstring_IHandler ()
		{
			if (cb_substring_I == null)
				cb_substring_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Substring_I);
			return cb_substring_I;
		}

		static IntPtr n_Substring_I (IntPtr jnienv, IntPtr native__this, int start)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Substring (start));
		}
#pragma warning restore 0169

		static IntPtr id_substring_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='substring' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("substring", "(I)Ljava/lang/String;", "GetSubstring_IHandler")]
		public virtual unsafe string Substring (int start)
		{
			if (id_substring_I == IntPtr.Zero)
				id_substring_I = JNIEnv.GetMethodID (class_ref, "substring", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (start);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_substring_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "substring", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_substring_II;
#pragma warning disable 0169
		static Delegate GetSubstring_IIHandler ()
		{
			if (cb_substring_II == null)
				cb_substring_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_Substring_II);
			return cb_substring_II;
		}

		static IntPtr n_Substring_II (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Substring (startIndex, endIndex));
		}
#pragma warning restore 0169

		static IntPtr id_substring_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='substring' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("substring", "(II)Ljava/lang/String;", "GetSubstring_IIHandler")]
		public virtual unsafe string Substring (int startIndex, int endIndex)
		{
			if (id_substring_II == IntPtr.Zero)
				id_substring_II = JNIEnv.GetMethodID (class_ref, "substring", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_substring_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "substring", "(II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toCharArray;
#pragma warning disable 0169
		static Delegate GetToCharArrayHandler ()
		{
			if (cb_toCharArray == null)
				cb_toCharArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToCharArray);
			return cb_toCharArray;
		}

		static IntPtr n_ToCharArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToCharArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toCharArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='toCharArray' and count(parameter)=0]"
		[Register ("toCharArray", "()[C", "GetToCharArrayHandler")]
		public virtual unsafe char[] ToCharArray ()
		{
			if (id_toCharArray == IntPtr.Zero)
				id_toCharArray = JNIEnv.GetMethodID (class_ref, "toCharArray", "()[C");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toCharArray), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCharArray", "()[C")), JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

		static Delegate cb_toCharArray_II;
#pragma warning disable 0169
		static Delegate GetToCharArray_IIHandler ()
		{
			if (cb_toCharArray_II == null)
				cb_toCharArray_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_ToCharArray_II);
			return cb_toCharArray_II;
		}

		static IntPtr n_ToCharArray_II (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToCharArray (startIndex, endIndex));
		}
#pragma warning restore 0169

		static IntPtr id_toCharArray_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='toCharArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toCharArray", "(II)[C", "GetToCharArray_IIHandler")]
		public virtual unsafe char[] ToCharArray (int startIndex, int endIndex)
		{
			if (id_toCharArray_II == IntPtr.Zero)
				id_toCharArray_II = JNIEnv.GetMethodID (class_ref, "toCharArray", "(II)[C");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);

				if (((object) this).GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toCharArray_II, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCharArray", "(II)[C"), __args), JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

		static Delegate cb_toStringBuffer;
#pragma warning disable 0169
		static Delegate GetToStringBufferHandler ()
		{
			if (cb_toStringBuffer == null)
				cb_toStringBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToStringBuffer);
			return cb_toStringBuffer;
		}

		static IntPtr n_ToStringBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToStringBuffer ());
		}
#pragma warning restore 0169

		static IntPtr id_toStringBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='toStringBuffer' and count(parameter)=0]"
		[Register ("toStringBuffer", "()Ljava/lang/StringBuffer;", "GetToStringBufferHandler")]
		public virtual unsafe global::Java.Lang.StringBuffer ToStringBuffer ()
		{
			if (id_toStringBuffer == IntPtr.Zero)
				id_toStringBuffer = JNIEnv.GetMethodID (class_ref, "toStringBuffer", "()Ljava/lang/StringBuffer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toStringBuffer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toStringBuffer", "()Ljava/lang/StringBuffer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toStringBuilder;
#pragma warning disable 0169
		static Delegate GetToStringBuilderHandler ()
		{
			if (cb_toStringBuilder == null)
				cb_toStringBuilder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToStringBuilder);
			return cb_toStringBuilder;
		}

		static IntPtr n_ToStringBuilder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToStringBuilder ());
		}
#pragma warning restore 0169

		static IntPtr id_toStringBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='toStringBuilder' and count(parameter)=0]"
		[Register ("toStringBuilder", "()Ljava/lang/StringBuilder;", "GetToStringBuilderHandler")]
		public virtual unsafe global::Java.Lang.StringBuilder ToStringBuilder ()
		{
			if (id_toStringBuilder == IntPtr.Zero)
				id_toStringBuilder = JNIEnv.GetMethodID (class_ref, "toStringBuilder", "()Ljava/lang/StringBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toStringBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toStringBuilder", "()Ljava/lang/StringBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trim;
#pragma warning disable 0169
		static Delegate GetTrimHandler ()
		{
			if (cb_trim == null)
				cb_trim = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Trim);
			return cb_trim;
		}

		static IntPtr n_Trim (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trim ());
		}
#pragma warning restore 0169

		static IntPtr id_trim;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='trim' and count(parameter)=0]"
		[Register ("trim", "()Lorg/apache/commons/lang3/text/StrBuilder;", "GetTrimHandler")]
		public virtual unsafe global::Org.Apache.Commons.Lang3.Text.StrBuilder Trim ()
		{
			if (id_trim == IntPtr.Zero)
				id_trim = JNIEnv.GetMethodID (class_ref, "trim", "()Lorg/apache/commons/lang3/text/StrBuilder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trim), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trim", "()Lorg/apache/commons/lang3/text/StrBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_validateIndex_I;
#pragma warning disable 0169
		static Delegate GetValidateIndex_IHandler ()
		{
			if (cb_validateIndex_I == null)
				cb_validateIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ValidateIndex_I);
			return cb_validateIndex_I;
		}

		static void n_ValidateIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValidateIndex (index);
		}
#pragma warning restore 0169

		static IntPtr id_validateIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='validateIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("validateIndex", "(I)V", "GetValidateIndex_IHandler")]
		protected virtual unsafe void ValidateIndex (int index)
		{
			if (id_validateIndex_I == IntPtr.Zero)
				id_validateIndex_I = JNIEnv.GetMethodID (class_ref, "validateIndex", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validateIndex_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateIndex", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_validateRange_II;
#pragma warning disable 0169
		static Delegate GetValidateRange_IIHandler ()
		{
			if (cb_validateRange_II == null)
				cb_validateRange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_ValidateRange_II);
			return cb_validateRange_II;
		}

		static int n_ValidateRange_II (IntPtr jnienv, IntPtr native__this, int startIndex, int endIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValidateRange (startIndex, endIndex);
		}
#pragma warning restore 0169

		static IntPtr id_validateRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrBuilder']/method[@name='validateRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("validateRange", "(II)I", "GetValidateRange_IIHandler")]
		protected virtual unsafe int ValidateRange (int startIndex, int endIndex)
		{
			if (id_validateRange_II == IntPtr.Zero)
				id_validateRange_II = JNIEnv.GetMethodID (class_ref, "validateRange", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startIndex);
				__args [1] = new JValue (endIndex);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_validateRange_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateRange", "(II)I"), __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
		{
			return Build ()?.ToString ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		public System.Collections.Generic.IEnumerator<char> GetEnumerator ()
		{
			for (int i = 0; i < Length(); i++)
				yield return CharAt (i);
		}

	}
}
