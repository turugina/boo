using System;

namespace Boo.Ast.Impl
{
	[Serializable]
	public abstract class TryStatementImpl : Statement
	{
		protected Block _protectedBlock;
		protected ExceptionHandlerCollection _exceptionHandlers;
		protected Block _successBlock;
		protected Block _ensureBlock;
		
		protected TryStatementImpl()
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 		}
		
		protected TryStatementImpl(Block successBlock, Block ensureBlock)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 			SuccessBlock = successBlock;
			EnsureBlock = ensureBlock;
		}
		
		protected TryStatementImpl(antlr.Token token, Block successBlock, Block ensureBlock) : base(token)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 			SuccessBlock = successBlock;
			EnsureBlock = ensureBlock;
		}
		
		internal TryStatementImpl(antlr.Token token) : base(token)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 		}
		
		internal TryStatementImpl(Node lexicalInfoProvider) : base(lexicalInfoProvider)
		{
			ProtectedBlock = new Block();
			_exceptionHandlers = new ExceptionHandlerCollection(this);
 		}
		
		public Block ProtectedBlock
		{
			get
			{
				return _protectedBlock;
			}
			
			set
			{
				_protectedBlock = value;
				if (null != _protectedBlock)
				{
					_protectedBlock.InitializeParent(this);
				}
			}
		}
		
		public ExceptionHandlerCollection ExceptionHandlers
		{
			get
			{
				return _exceptionHandlers;
			}
			
			set
			{
				_exceptionHandlers = value;
				if (null != _exceptionHandlers)
				{
					_exceptionHandlers.InitializeParent(this);
				}
			}
		}
		
		public Block SuccessBlock
		{
			get
			{
				return _successBlock;
			}
			
			set
			{
				_successBlock = value;
				if (null != _successBlock)
				{
					_successBlock.InitializeParent(this);
				}
			}
		}
		
		public Block EnsureBlock
		{
			get
			{
				return _ensureBlock;
			}
			
			set
			{
				_ensureBlock = value;
				if (null != _ensureBlock)
				{
					_ensureBlock.InitializeParent(this);
				}
			}
		}
	}
}
