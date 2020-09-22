using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/SerializationUtils", DoNotGenerateAcw=true)]
	public partial class SerializationUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/SerializationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerializationUtils); }
		}

		protected SerializationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/constructor[@name='SerializationUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SerializationUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SerializationUtils)) {
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

		static IntPtr id_clone_Ljava_io_Serializable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("clone", "(Ljava/io/Serializable;)Ljava/io/Serializable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.io.Serializable"})]
		public static unsafe global::Java.Lang.Object Clone (global::Java.Lang.Object @object)
		{
			if (id_clone_Ljava_io_Serializable_ == IntPtr.Zero)
				id_clone_Ljava_io_Serializable_ = JNIEnv.GetStaticMethodID (class_ref, "clone", "(Ljava/io/Serializable;)Ljava/io/Serializable;");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__object);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_clone_Ljava_io_Serializable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static IntPtr id_deserialize_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("deserialize", "([B)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Deserialize (byte[] objectData)
		{
			if (id_deserialize_arrayB == IntPtr.Zero)
				id_deserialize_arrayB = JNIEnv.GetStaticMethodID (class_ref, "deserialize", "([B)Ljava/lang/Object;");
			IntPtr native_objectData = JNIEnv.NewArray (objectData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_objectData);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_deserialize_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (objectData != null) {
					JNIEnv.CopyArray (native_objectData, objectData);
					JNIEnv.DeleteLocalRef (native_objectData);
				}
			}
		}

		static IntPtr id_deserialize_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("deserialize", "(Ljava/io/InputStream;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Deserialize (global::System.IO.Stream inputStream)
		{
			if (id_deserialize_Ljava_io_InputStream_ == IntPtr.Zero)
				id_deserialize_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "deserialize", "(Ljava/io/InputStream;)Ljava/lang/Object;");
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inputStream);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_deserialize_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
			}
		}

		static IntPtr id_roundtrip_Ljava_io_Serializable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='roundtrip' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("roundtrip", "(Ljava/io/Serializable;)Ljava/io/Serializable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.io.Serializable"})]
		public static unsafe global::Java.Lang.Object Roundtrip (global::Java.Lang.Object msg)
		{
			if (id_roundtrip_Ljava_io_Serializable_ == IntPtr.Zero)
				id_roundtrip_Ljava_io_Serializable_ = JNIEnv.GetStaticMethodID (class_ref, "roundtrip", "(Ljava/io/Serializable;)Ljava/io/Serializable;");
			IntPtr native_msg = JNIEnv.ToLocalJniHandle (msg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msg);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_roundtrip_Ljava_io_Serializable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static IntPtr id_serialize_Ljava_io_Serializable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.io.Serializable']]"
		[Register ("serialize", "(Ljava/io/Serializable;)[B", "")]
		public static unsafe byte[] Serialize (global::Java.IO.ISerializable obj)
		{
			if (id_serialize_Ljava_io_Serializable_ == IntPtr.Zero)
				id_serialize_Ljava_io_Serializable_ = JNIEnv.GetStaticMethodID (class_ref, "serialize", "(Ljava/io/Serializable;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_serialize_Ljava_io_Serializable_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_serialize_Ljava_io_Serializable_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SerializationUtils']/method[@name='serialize' and count(parameter)=2 and parameter[1][@type='java.io.Serializable'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("serialize", "(Ljava/io/Serializable;Ljava/io/OutputStream;)V", "")]
		public static unsafe void Serialize (global::Java.IO.ISerializable obj, global::System.IO.Stream outputStream)
		{
			if (id_serialize_Ljava_io_Serializable_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_serialize_Ljava_io_Serializable_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "serialize", "(Ljava/io/Serializable;Ljava/io/OutputStream;)V");
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (native_outputStream);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_serialize_Ljava_io_Serializable_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputStream);
			}
		}

	}
}
