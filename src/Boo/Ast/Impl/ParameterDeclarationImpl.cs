#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Sat Jan 17 18:51:42 2004
//
using System;

namespace Boo.Ast.Impl
{
	[Serializable]
	public abstract class ParameterDeclarationImpl : Node, INodeWithAttributes
	{
		protected string _name;
		protected TypeReference _type;
		protected AttributeCollection _attributes;
		
		protected ParameterDeclarationImpl()
		{
			_attributes = new AttributeCollection(this);
 		}
		
		protected ParameterDeclarationImpl(string name, TypeReference type)
		{
			_attributes = new AttributeCollection(this);
 			Name = name;
			Type = type;
		}
		
		protected ParameterDeclarationImpl(LexicalInfo lexicalInfo, string name, TypeReference type) : base(lexicalInfo)
		{
			_attributes = new AttributeCollection(this);
 			Name = name;				
			Type = type;				
		}
		
		protected ParameterDeclarationImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
			_attributes = new AttributeCollection(this);
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.ParameterDeclaration;
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			
			set
			{
				
				_name = value;
			}
		}
		public TypeReference Type
		{
			get
			{
				return _type;
			}
			
			set
			{
				
				if (_type != value)
				{
					_type = value;
					if (null != _type)
					{
						_type.InitializeParent(this);
					}
				}
			}
		}
		public AttributeCollection Attributes
		{
			get
			{
				return _attributes;
			}
			
			set
			{
				
				if (_attributes != value)
				{
					_attributes = value;
					if (null != _attributes)
					{
						_attributes.InitializeParent(this);
					}
				}
			}
		}
		public override void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			ParameterDeclaration thisNode = (ParameterDeclaration)this;
			ParameterDeclaration resultingTypedNode = thisNode;
			transformer.OnParameterDeclaration(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
