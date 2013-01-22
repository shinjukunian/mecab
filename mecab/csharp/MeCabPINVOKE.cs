/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace MeCab {

using System;
using System.Runtime.InteropServices;

class MeCabPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("MeCab", EntryPoint="SWIGRegisterExceptionCallbacks_MeCab")]
    public static extern void SWIGRegisterExceptionCallbacks_MeCab(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("MeCab", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_MeCab")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_MeCab(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_MeCab(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_MeCab(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(MeCabPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(MeCabPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("MeCab", EntryPoint="SWIGRegisterStringCallback_MeCab")]
    public static extern void SWIGRegisterStringCallback_MeCab(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_MeCab(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static MeCabPINVOKE() {
  }


  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_filename_get")]
  public static extern string DictionaryInfo_filename_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_charset_get")]
  public static extern string DictionaryInfo_charset_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_size_get")]
  public static extern uint DictionaryInfo_size_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_type_get")]
  public static extern int DictionaryInfo_type_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_lsize_get")]
  public static extern uint DictionaryInfo_lsize_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_rsize_get")]
  public static extern uint DictionaryInfo_rsize_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_version_get")]
  public static extern ushort DictionaryInfo_version_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_DictionaryInfo_next_get")]
  public static extern IntPtr DictionaryInfo_next_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_new_DictionaryInfo")]
  public static extern IntPtr new_DictionaryInfo();

  [DllImport("MeCab", EntryPoint="CSharp_delete_DictionaryInfo")]
  public static extern void delete_DictionaryInfo(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_rnode_get")]
  public static extern IntPtr Path_rnode_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_rnext_get")]
  public static extern IntPtr Path_rnext_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_lnode_get")]
  public static extern IntPtr Path_lnode_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_lnext_get")]
  public static extern IntPtr Path_lnext_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_cost_get")]
  public static extern int Path_cost_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Path_prob_set")]
  public static extern void Path_prob_set(HandleRef jarg1, float jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Path_prob_get")]
  public static extern float Path_prob_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_prev_get")]
  public static extern IntPtr Node_prev_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_next_get")]
  public static extern IntPtr Node_next_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_enext_get")]
  public static extern IntPtr Node_enext_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_bnext_get")]
  public static extern IntPtr Node_bnext_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_rpath_get")]
  public static extern IntPtr Node_rpath_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_lpath_get")]
  public static extern IntPtr Node_lpath_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_feature_get")]
  public static extern string Node_feature_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_id_get")]
  public static extern uint Node_id_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_length_get")]
  public static extern ushort Node_length_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_rlength_get")]
  public static extern ushort Node_rlength_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_rcAttr_get")]
  public static extern ushort Node_rcAttr_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_lcAttr_get")]
  public static extern ushort Node_lcAttr_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_posid_get")]
  public static extern ushort Node_posid_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_char_type_get")]
  public static extern byte Node_char_type_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_stat_get")]
  public static extern byte Node_stat_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_isbest_get")]
  public static extern byte Node_isbest_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_alpha_get")]
  public static extern float Node_alpha_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_beta_get")]
  public static extern float Node_beta_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_prob_set")]
  public static extern void Node_prob_set(HandleRef jarg1, float jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Node_prob_get")]
  public static extern float Node_prob_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_wcost_get")]
  public static extern short Node_wcost_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_cost_get")]
  public static extern int Node_cost_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Node_surface_get")]
  public static extern string Node_surface_get(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_NOR_NODE_get")]
  public static extern int MECAB_NOR_NODE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_UNK_NODE_get")]
  public static extern int MECAB_UNK_NODE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_BOS_NODE_get")]
  public static extern int MECAB_BOS_NODE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_EOS_NODE_get")]
  public static extern int MECAB_EOS_NODE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_EON_NODE_get")]
  public static extern int MECAB_EON_NODE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_SYS_DIC_get")]
  public static extern int MECAB_SYS_DIC_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_USR_DIC_get")]
  public static extern int MECAB_USR_DIC_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_UNK_DIC_get")]
  public static extern int MECAB_UNK_DIC_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_ONE_BEST_get")]
  public static extern int MECAB_ONE_BEST_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_NBEST_get")]
  public static extern int MECAB_NBEST_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_PARTIAL_get")]
  public static extern int MECAB_PARTIAL_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_MARGINAL_PROB_get")]
  public static extern int MECAB_MARGINAL_PROB_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_ALTERNATIVE_get")]
  public static extern int MECAB_ALTERNATIVE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_ALL_MORPHS_get")]
  public static extern int MECAB_ALL_MORPHS_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_ALLOCATE_SENTENCE_get")]
  public static extern int MECAB_ALLOCATE_SENTENCE_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_ANY_BOUNDARY_get")]
  public static extern int MECAB_ANY_BOUNDARY_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_TOKEN_BOUNDARY_get")]
  public static extern int MECAB_TOKEN_BOUNDARY_get();

  [DllImport("MeCab", EntryPoint="CSharp_MECAB_INSIDE_TOKEN_get")]
  public static extern int MECAB_INSIDE_TOKEN_get();

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_clear")]
  public static extern void Lattice_clear(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_is_available")]
  public static extern bool Lattice_is_available(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_bos_node")]
  public static extern IntPtr Lattice_bos_node(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_eos_node")]
  public static extern IntPtr Lattice_eos_node(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_end_nodes")]
  public static extern IntPtr Lattice_end_nodes(HandleRef jarg1, uint jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_begin_nodes")]
  public static extern IntPtr Lattice_begin_nodes(HandleRef jarg1, uint jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_sentence")]
  public static extern string Lattice_sentence(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_size")]
  public static extern uint Lattice_size(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_Z")]
  public static extern void Lattice_set_Z(HandleRef jarg1, double jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_Z")]
  public static extern double Lattice_Z(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_theta")]
  public static extern void Lattice_set_theta(HandleRef jarg1, float jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_theta")]
  public static extern float Lattice_theta(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_next")]
  public static extern bool Lattice_next(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_request_type")]
  public static extern int Lattice_request_type(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_has_request_type")]
  public static extern bool Lattice_has_request_type(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_request_type")]
  public static extern void Lattice_set_request_type(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_add_request_type")]
  public static extern void Lattice_add_request_type(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_remove_request_type")]
  public static extern void Lattice_remove_request_type(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_newNode")]
  public static extern IntPtr Lattice_newNode(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_toString__SWIG_0")]
  public static extern string Lattice_toString__SWIG_0(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_toString__SWIG_1")]
  public static extern string Lattice_toString__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_enumNBestAsString")]
  public static extern string Lattice_enumNBestAsString(HandleRef jarg1, uint jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_has_constraint")]
  public static extern bool Lattice_has_constraint(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_boundary_constraint")]
  public static extern int Lattice_boundary_constraint(HandleRef jarg1, uint jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_feature_constraint")]
  public static extern string Lattice_feature_constraint(HandleRef jarg1, uint jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_boundary_constraint")]
  public static extern void Lattice_set_boundary_constraint(HandleRef jarg1, uint jarg2, int jarg3);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_feature_constraint")]
  public static extern void Lattice_set_feature_constraint(HandleRef jarg1, uint jarg2, uint jarg3, string jarg4);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_what")]
  public static extern string Lattice_what(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_what")]
  public static extern void Lattice_set_what(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_delete_Lattice")]
  public static extern void delete_Lattice(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_new_Lattice")]
  public static extern IntPtr new_Lattice();

  [DllImport("MeCab", EntryPoint="CSharp_Lattice_set_sentence")]
  public static extern void Lattice_set_sentence(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Model_dictionary_info")]
  public static extern IntPtr Model_dictionary_info(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Model_transition_cost")]
  public static extern int Model_transition_cost(HandleRef jarg1, ushort jarg2, ushort jarg3);

  [DllImport("MeCab", EntryPoint="CSharp_Model_lookup")]
  public static extern IntPtr Model_lookup(HandleRef jarg1, string jarg2, string jarg3, HandleRef jarg4);

  [DllImport("MeCab", EntryPoint="CSharp_Model_createTagger")]
  public static extern IntPtr Model_createTagger(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Model_createLattice")]
  public static extern IntPtr Model_createLattice(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Model_swap")]
  public static extern bool Model_swap(HandleRef jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Model_version")]
  public static extern string Model_version();

  [DllImport("MeCab", EntryPoint="CSharp_delete_Model")]
  public static extern void delete_Model(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Model_create__SWIG_0")]
  public static extern IntPtr Model_create__SWIG_0(int jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Model_create__SWIG_1")]
  public static extern IntPtr Model_create__SWIG_1(string jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_new_Model__SWIG_0")]
  public static extern IntPtr new_Model__SWIG_0(string jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_new_Model__SWIG_1")]
  public static extern IntPtr new_Model__SWIG_1();

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parse__SWIG_0")]
  public static extern bool Tagger_parse__SWIG_0(HandleRef jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parse__SWIG_1")]
  public static extern bool Tagger_parse__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parse__SWIG_2")]
  public static extern string Tagger_parse__SWIG_2(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parseToNode")]
  public static extern IntPtr Tagger_parseToNode(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parseNBest")]
  public static extern string Tagger_parseNBest(HandleRef jarg1, uint jarg2, string jarg3);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parseNBestInit")]
  public static extern bool Tagger_parseNBestInit(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_nextNode")]
  public static extern IntPtr Tagger_nextNode(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_next")]
  public static extern string Tagger_next(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_formatNode")]
  public static extern string Tagger_formatNode(HandleRef jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_set_request_type")]
  public static extern void Tagger_set_request_type(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_request_type")]
  public static extern int Tagger_request_type(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_partial")]
  public static extern bool Tagger_partial(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_set_partial")]
  public static extern void Tagger_set_partial(HandleRef jarg1, bool jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_lattice_level")]
  public static extern int Tagger_lattice_level(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_set_lattice_level")]
  public static extern void Tagger_set_lattice_level(HandleRef jarg1, int jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_all_morphs")]
  public static extern bool Tagger_all_morphs(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_set_all_morphs")]
  public static extern void Tagger_set_all_morphs(HandleRef jarg1, bool jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_set_theta")]
  public static extern void Tagger_set_theta(HandleRef jarg1, float jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_theta")]
  public static extern float Tagger_theta(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_dictionary_info")]
  public static extern IntPtr Tagger_dictionary_info(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_what")]
  public static extern string Tagger_what(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_delete_Tagger")]
  public static extern void delete_Tagger(HandleRef jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_create__SWIG_0")]
  public static extern IntPtr Tagger_create__SWIG_0(int jarg1, HandleRef jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_create__SWIG_1")]
  public static extern IntPtr Tagger_create__SWIG_1(string jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_version")]
  public static extern string Tagger_version();

  [DllImport("MeCab", EntryPoint="CSharp_new_Tagger__SWIG_0")]
  public static extern IntPtr new_Tagger__SWIG_0(string jarg1);

  [DllImport("MeCab", EntryPoint="CSharp_new_Tagger__SWIG_1")]
  public static extern IntPtr new_Tagger__SWIG_1();

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parseToString__SWIG_0")]
  public static extern string Tagger_parseToString__SWIG_0(HandleRef jarg1, string jarg2, uint jarg3);

  [DllImport("MeCab", EntryPoint="CSharp_Tagger_parseToString__SWIG_1")]
  public static extern string Tagger_parseToString__SWIG_1(HandleRef jarg1, string jarg2);

  [DllImport("MeCab", EntryPoint="CSharp_VERSION_get")]
  public static extern string VERSION_get();
}

}
