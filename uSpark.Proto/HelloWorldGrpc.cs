// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HelloWorld.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Endpoints.Hellohorld.Sraka {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "endpoints.hellohorld.sraka.Greeter";

    static readonly grpc::Marshaller<global::Endpoints.Hellohorld.Sraka.HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Endpoints.Hellohorld.Sraka.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Endpoints.Hellohorld.Sraka.HelloReply> __Marshaller_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Endpoints.Hellohorld.Sraka.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply> __Method_SayHello = new grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    static readonly grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply> __Method_SayHelloAgain = new grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHelloAgain",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    static readonly grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply> __Method_SayHelloAuth = new grpc::Method<global::Endpoints.Hellohorld.Sraka.HelloRequest, global::Endpoints.Hellohorld.Sraka.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHelloAuth",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Endpoints.Hellohorld.Sraka.HelloWorldReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHello(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAgain(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Can be used after authentication
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAuth(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHello(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHello(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHelloAgain(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAgain(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHelloAgain(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHelloAgain, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAgainAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAgainAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAgainAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHelloAgain, null, options, request);
      }
      /// <summary>
      /// Can be used after authentication
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHelloAuth(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAuth(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Can be used after authentication
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Endpoints.Hellohorld.Sraka.HelloReply SayHelloAuth(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHelloAuth, null, options, request);
      }
      /// <summary>
      /// Can be used after authentication
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAuthAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAuthAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Can be used after authentication
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Endpoints.Hellohorld.Sraka.HelloReply> SayHelloAuthAsync(global::Endpoints.Hellohorld.Sraka.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHelloAuth, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SayHelloAgain, serviceImpl.SayHelloAgain)
          .AddMethod(__Method_SayHelloAuth, serviceImpl.SayHelloAuth).Build();
    }

  }
}
#endregion
