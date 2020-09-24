using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Room {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']"
	[Register ("com/vivalnk/sdk/repository/local/database/room/IRoomDataDAO", "", "Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker")]
	public partial interface IRoomDataDAO : IJavaObject, IJavaPeerable {

		long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()J", "GetGetCountHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalData_Room...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		void DeleteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='getCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCount", "(Ljava/lang/String;)J", "GetGetCount_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		long GetCount (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalData_Room...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='query' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("query", "(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;", "GetQuery_Ljava_lang_String_JHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room Query (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='query' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("query", "(Ljava/lang/String;JJ)Ljava/util/List;", "GetQuery_Ljava_lang_String_JJHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> Query (string p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='queryAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryAll", "(Ljava/lang/String;)Ljava/util/List;", "GetQueryAll_Ljava_lang_String_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryAll (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='queryLatestAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("queryLatestAll", "(J)Ljava/util/List;", "GetQueryLatestAll_JHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryLatestAll (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='queryOldestAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("queryOldestAll", "(J)Ljava/util/List;", "GetQueryOldestAll_JHandler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryOldestAll (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/interface[@name='IRoomDataDAO']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.room.VitalData_Room...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAOInvoker, ECGCoreSDK")]
		void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/room/IRoomDataDAO", DoNotGenerateAcw=true)]
	internal partial class IRoomDataDAOInvoker : global::Java.Lang.Object, IRoomDataDAO {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/room/IRoomDataDAO", typeof (IRoomDataDAOInvoker));

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

		public static IRoomDataDAO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRoomDataDAO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.repository.local.database.room.IRoomDataDAO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoomDataDAOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCount);
			return cb_getCount;
		}

		static long n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe long Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
			}
		}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		public unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0)
		{
			if (id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == IntPtr.Zero)
				id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNIEnv.GetMethodID (class_ref, "delete", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteAll);
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		IntPtr id_deleteAll;
		public unsafe void DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll);
		}

		static Delegate cb_getCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCount_Ljava_lang_String_Handler ()
		{
			if (cb_getCount_Ljava_lang_String_ == null)
				cb_getCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetCount_Ljava_lang_String_);
			return cb_getCount_Ljava_lang_String_;
		}

		static long n_GetCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCount_Ljava_lang_String_;
		public unsafe long GetCount (string p0)
		{
			if (id_getCount_Ljava_lang_String_ == IntPtr.Zero)
				id_getCount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCount", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCount_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		public unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0)
		{
			if (id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == IntPtr.Zero)
				id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNIEnv.GetMethodID (class_ref, "insert", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_query_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JHandler ()
		{
			if (cb_query_Ljava_lang_String_J == null)
				cb_query_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Query_Ljava_lang_String_J);
			return cb_query_Ljava_lang_String_J;
		}

		static IntPtr n_Query_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_J;
		public unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room Query (string p0, long p1)
		{
			if (id_query_Ljava_lang_String_J == IntPtr.Zero)
				id_query_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_query_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JJHandler ()
		{
			if (cb_query_Ljava_lang_String_JJ == null)
				cb_query_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_L) n_Query_Ljava_lang_String_JJ);
			return cb_query_Ljava_lang_String_JJ;
		}

		static IntPtr n_Query_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.ToLocalJniHandle (__this.Query (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_JJ;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> Query (string p0, long p1, long p2)
		{
			if (id_query_Ljava_lang_String_JJ == IntPtr.Zero)
				id_query_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;JJ)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queryAll;
#pragma warning disable 0169
		static Delegate GetQueryAllHandler ()
		{
			if (cb_queryAll == null)
				cb_queryAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAll);
			return cb_queryAll;
		}

		static IntPtr n_QueryAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		IntPtr id_queryAll;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryAll ()
		{
			if (id_queryAll == IntPtr.Zero)
				id_queryAll = JNIEnv.GetMethodID (class_ref, "queryAll", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryAll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_queryAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryAll_Ljava_lang_String_Handler ()
		{
			if (cb_queryAll_Ljava_lang_String_ == null)
				cb_queryAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_QueryAll_Ljava_lang_String_);
			return cb_queryAll_Ljava_lang_String_;
		}

		static IntPtr n_QueryAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.ToLocalJniHandle (__this.QueryAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_queryAll_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryAll (string p0)
		{
			if (id_queryAll_Ljava_lang_String_ == IntPtr.Zero)
				id_queryAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryAll", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queryLatestAll_J;
#pragma warning disable 0169
		static Delegate GetQueryLatestAll_JHandler ()
		{
			if (cb_queryLatestAll_J == null)
				cb_queryLatestAll_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_QueryLatestAll_J);
			return cb_queryLatestAll_J;
		}

		static IntPtr n_QueryLatestAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.ToLocalJniHandle (__this.QueryLatestAll (p0));
		}
#pragma warning restore 0169

		IntPtr id_queryLatestAll_J;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryLatestAll (long p0)
		{
			if (id_queryLatestAll_J == IntPtr.Zero)
				id_queryLatestAll_J = JNIEnv.GetMethodID (class_ref, "queryLatestAll", "(J)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryLatestAll_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_queryOldestAll_J;
#pragma warning disable 0169
		static Delegate GetQueryOldestAll_JHandler ()
		{
			if (cb_queryOldestAll_J == null)
				cb_queryOldestAll_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_QueryOldestAll_J);
			return cb_queryOldestAll_J;
		}

		static IntPtr n_QueryOldestAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.ToLocalJniHandle (__this.QueryOldestAll (p0));
		}
#pragma warning restore 0169

		IntPtr id_queryOldestAll_J;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room> QueryOldestAll (long p0)
		{
			if (id_queryOldestAll_J == IntPtr.Zero)
				id_queryOldestAll_J = JNIEnv.GetMethodID (class_ref, "queryOldestAll", "(J)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryOldestAll_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_;
		public unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalData_Room[] p0)
		{
			if (id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ == IntPtr.Zero)
				id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_ = JNIEnv.GetMethodID (class_ref, "update", "([Lcom/vivalnk/sdk/repository/local/database/room/VitalData_Room;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_arrayLcom_vivalnk_sdk_repository_local_database_room_VitalData_Room_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
