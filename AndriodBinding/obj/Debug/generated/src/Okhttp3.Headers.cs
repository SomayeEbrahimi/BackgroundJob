using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Headers']"
	[global::Android.Runtime.Register ("okhttp3/Headers", DoNotGenerateAcw=true)]
	public sealed partial class Headers : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Headers$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/Headers$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/constructor[@name='Headers.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_add_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Add (string line)
			{
				if (id_add_Ljava_lang_String_ == IntPtr.Zero)
					id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;");
				IntPtr native_line = JNIEnv.NewString (line);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_line);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_line);
				}
			}

			static IntPtr id_add_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Add (string name, string value)
			{
				if (id_add_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_add_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_add_Ljava_lang_String_Ljava_util_Date_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date']]"
			[Register ("add", "(Ljava/lang/String;Ljava/util/Date;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Add (string name, global::Java.Util.Date value)
			{
				if (id_add_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
					id_add_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/util/Date;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (value);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_addAll_Lokhttp3_Headers_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("addAll", "(Lokhttp3/Headers;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder AddAll (global::Okhttp3.Headers headers)
			{
				if (id_addAll_Lokhttp3_Headers_ == IntPtr.Zero)
					id_addAll_Lokhttp3_Headers_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Lokhttp3/Headers;)Lokhttp3/Headers$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (headers);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addAll_Lokhttp3_Headers_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_addUnsafeNonAscii_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='addUnsafeNonAscii' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addUnsafeNonAscii", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder AddUnsafeNonAscii (string name, string value)
			{
				if (id_addUnsafeNonAscii_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addUnsafeNonAscii_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addUnsafeNonAscii", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addUnsafeNonAscii_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Headers;", "")]
			public unsafe global::Okhttp3.Headers Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/Headers;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_get_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string Get (string name)
			{
				if (id_get_Ljava_lang_String_ == IntPtr.Zero)
					id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_removeAll_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAll", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder RemoveAll (string name)
			{
				if (id_removeAll_Ljava_lang_String_ == IntPtr.Zero)
					id_removeAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_set_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Set (string name, string value)
			{
				if (id_set_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_set_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_set_Ljava_lang_String_Ljava_util_Date_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers.Builder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date']]"
			[Register ("set", "(Ljava/lang/String;Ljava/util/Date;)Lokhttp3/Headers$Builder;", "")]
			public unsafe global::Okhttp3.Headers.Builder Set (string name, global::Java.Util.Date value)
			{
				if (id_set_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
					id_set_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/util/Date;)Lokhttp3/Headers$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (value);
					global::Okhttp3.Headers.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Headers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Headers); }
		}

		internal Headers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_byteCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='byteCount' and count(parameter)=0]"
		[Register ("byteCount", "()J", "")]
		public unsafe long ByteCount ()
		{
			if (id_byteCount == IntPtr.Zero)
				id_byteCount = JNIEnv.GetMethodID (class_ref, "byteCount", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_byteCount);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Get (string name)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_getDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='getDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDate", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public unsafe global::Java.Util.Date GetDate (string name)
		{
			if (id_getDate_Ljava_lang_String_ == IntPtr.Zero)
				id_getDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDate", "(Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_name_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name", "(I)Ljava/lang/String;", "")]
		public unsafe string Name (int index)
		{
			if (id_name_I == IntPtr.Zero)
				id_name_I = JNIEnv.GetMethodID (class_ref, "name", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_names;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='names' and count(parameter)=0]"
		[Register ("names", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> Names ()
		{
			if (id_names == IntPtr.Zero)
				id_names = JNIEnv.GetMethodID (class_ref, "names", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_names), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/Headers$Builder;", "")]
		public unsafe global::Okhttp3.Headers.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lokhttp3/Headers$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_of_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("of", "([Ljava/lang/String;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers Of (params string[] namesAndValues)
		{
			if (id_of_arrayLjava_lang_String_ == IntPtr.Zero)
				id_of_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "of", "([Ljava/lang/String;)Lokhttp3/Headers;");
			IntPtr native_namesAndValues = JNIEnv.NewArray (namesAndValues);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_namesAndValues);
				global::Okhttp3.Headers __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (namesAndValues != null) {
					JNIEnv.CopyArray (native_namesAndValues, namesAndValues);
					JNIEnv.DeleteLocalRef (native_namesAndValues);
				}
			}
		}

		static IntPtr id_of_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("of", "(Ljava/util/Map;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers Of (global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			if (id_of_Ljava_util_Map_ == IntPtr.Zero)
				id_of_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/util/Map;)Lokhttp3/Headers;");
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_headers);
				global::Okhttp3.Headers __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

		static IntPtr id_toMultimap;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='toMultimap' and count(parameter)=0]"
		[Register ("toMultimap", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ToMultimap ()
		{
			if (id_toMultimap == IntPtr.Zero)
				id_toMultimap = JNIEnv.GetMethodID (class_ref, "toMultimap", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMultimap), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_value_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='value' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("value", "(I)Ljava/lang/String;", "")]
		public unsafe string Value (int index)
		{
			if (id_value_I == IntPtr.Zero)
				id_value_I = JNIEnv.GetMethodID (class_ref, "value", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_values_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Headers']/method[@name='values' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("values", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Values (string name)
		{
			if (id_values_Ljava_lang_String_ == IntPtr.Zero)
				id_values_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "values", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_values_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
