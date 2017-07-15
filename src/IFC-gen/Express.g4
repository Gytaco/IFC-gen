grammar Express;

schemaDeclaration
	: SCHEMA Version ';' typeDeclaration* entityDeclaration* functionDeclaration*  END_SCHEMA';' EOF;

typeDeclaration 
	: TYPE typeName EQ valueType FIXED? ';' typeDeclarationBody? END_TYPE ';' ;

typeName	
	: Identifier
	;

atomicValueType
	: BINARY_SIZED
	| BOOLEAN
	| INTEGER
	| LOGICAL
	| REAL
	| STRING
	| STRING_SIZED
	| Identifier
	;

valueType 
	: atomicValueType
	| enumeration
	| select
	| setDeclaration
	| arrayDeclaration
	| listDeclaration
	;
	
setDeclaration
	: SET setParameters OF UNIQUE? atomicValueType
	| SET setParameters (OF SET setParameters)+ OF atomicValueType
	;

arrayDeclaration
	: ARRAY setParameters OF UNIQUE? atomicValueType
	| ARRAY setParameters (OF ARRAY setParameters)+ OF atomicValueType
	;

listDeclaration
	: LIST setParameters OF UNIQUE? atomicValueType
	| LIST setParameters (OF UNIQUE? LIST setParameters)+ OF atomicValueType
	;

setParameters
	: '[' Integer COLON (setSize|'?') ']'
	;

setSize
	: Integer
	| Identifier
	;

enumeration
	: ENUMERATION OF LP enumIdList RP 
	;

enumIdList
	: idList
	;

select
	: SELECT LP selectIdList RP
	;

selectIdList
	: idList
	;

idList
	: Identifier(','Identifier)*
	| IfcType(','IfcType)*
	;

typeDeclarationBody 
	: ruleDeclaration 
	;

ruleDeclaration : 'WHERE' rule+ ;

rule 
	: Identifier COLON boolExpr ';'
	;

expr
	: funcCallExpr
	| mulDivExpr
	| addSubExpr
	| boolExpr
	;

atom 
	: LP NOT? expr RP
	| NOT? LP expr RP
	| SELF
	| IfcType
	| Integer 
	| Float
	| Scientific
	| Identifier
	| path
	| propertyAccessor
	| setAccessor
	| '[' idList ']'
	| '[' Float(','Float)+ ']'
	| funcCallExpr
	| funcCallExpr(LOR funcCallExpr)+ // a || b || c
	| '?' // See line 4028
	;

boolExpr
	: atom MOD atom EQ atom
	| SIZEOF LP mulDivExpr RP EQ atom //See line 3231
	| (atom|funcCallExpr|mulDivExpr|addSubExpr) (LT|GT|LTE|GTE|EQ|NEQ|SAME|NOT_SAME) (atom|funcCallExpr|mulDivExpr|addSubExpr)
	| LB atom((LT|GT|LTE|GTE|EQ|SAME|NOT_SAME)atom)* RB
	| NOT? (atom|funcCallExpr) ((AND|OR|XOR) NOT? (atom|funcCallExpr))* 
	| (IfcType|path|propertyAccessor|Identifier|SELF) IN (funcCallExpr|'['idList']'|propertyAccessor)
	;

funcCallExpr
	: (EXISTS|SIZEOF|TYPEOF|ABS|USEDIN|Identifier)LP funcParameters RP
	| (EXISTS|SIZEOF|TYPEOF|ABS|USEDIN|Identifier)LP RP // A function call with no parameters.
	;

funcParameters
	: queryExpr
	| atom(','atom)*
	;

queryExpr
	: QUERY LP Identifier INIT (Identifier|path|propertyAccessor|funcCallExpr|queryExpr) PIPE boolExpr RP
	;

mulDivExpr
	: (atom|addSubExpr)((MUL|DIV)(atom|addSubExpr))+
	; 

addSubExpr
	: atom((ADD|SUB)atom)+
	;

entityDeclaration
	: ENTITY entityName ';'? entityDeclarationBody END_ENTITY ';' 
	;

entityName
	: Identifier
	;

entityDeclarationBody
	: attribute* supertypeDeclaration? subtypeDeclaration? deriveDeclaration? inverseDeclaration? uniqueDeclaration? ruleDeclaration? 
	;

supertypeDeclaration 
	: abstract SUPERTYPE OF LP (oneOf | supertypeName) RP ';'? attribute* 
	;

abstract
	: ABSTRACT?
	;

supertypeName
	: Identifier
	;

subtypeDeclaration 
	: SUBTYPE OF LP (oneOf | subtypeName) RP ';' attribute* 
	;

subtypeName
	: Identifier
	;

attribute
	: attributeName COLON optional valueType definition? ';'
	;

optional
	: OPTIONAL?
	;

attributeName
	: Identifier
	| path
	;

definition
	: DEF (atom|expr);

oneOf 
	: ONEOF LP idList RP 
	;

inverseDeclaration
	: INVERSE inverseExpression+
	;

inverseExpression
	: Identifier COLON (Identifier|setDeclaration|arrayDeclaration|listDeclaration) FOR Identifier ';'
	;

deriveDeclaration
	: DERIVE attribute+
	;

uniqueDeclaration
	: UNIQUE uniqueStatement+ 
	;

uniqueStatement
	: Identifier COLON (Identifier|idList) ';' 
	;

functionDeclaration 
	: 'FUNCTION' functionDeclarationBody 'END_FUNCTION' ;

functionDeclarationBody
	: .*? ;

path
	: (SELF'\\')? (Identifier|propertyAccessor)('\\'(Identifier|propertyAccessor))*
	;

propertyAccessor
	:  (setAccessor|Identifier|funcCallExpr|SELF)('.'(setAccessor|Identifier))+
	;

setAccessor
	: Identifier '[' (Integer|Identifier) ']'
	| SELF '[' (Integer|Identifier) ']'
	;
// Lexer

//Base Types
BINARY_SIZED : 'BINARY(' Integer ')';
BOOLEAN : 'BOOLEAN' ;
INTEGER : 'INTEGER' ;
LIST : 'LIST';
LOGICAL : 'LOGICAL' ;
REAL : 'REAL' ;
SET : 'SET' ;
STRING_SIZED : 'STRING(' Integer ')';
FIXED : 'FIXED';
STRING : 'STRING' ;
ARRAY : 'ARRAY' ;

// Keywords
ABSTRACT : 'ABSTRACT' ;
AND : 'AND' ;
DERIVE : 'DERIVE' ;
ENTITY : 'ENTITY' ;
END_ENTITY : 'END_ENTITY' ;
ENUMERATION : 'ENUMERATION' ;
FOR : 'FOR' ;
IN : 'IN' ;
INVERSE : 'INVERSE';
MOD : 'MOD' ;
OF : 'OF';
ONEOF : 'ONEOF' ;
OPTIONAL : 'OPTIONAL' ;
OR : 'OR' ;
SCHEMA : 'SCHEMA' ;
END_SCHEMA : 'END_SCHEMA' ;
SELECT : 'SELECT' ;
SELF : 'SELF' ;
SUBTYPE : 'SUBTYPE' ;
SUPERTYPE : 'SUPERTYPE' ;
TYPE : 'TYPE' ;
END_TYPE : 'END_TYPE' ;
UNIQUE : 'UNIQUE' ;
WHERE : 'WHERE' ;
XOR : 'XOR' ;

// Functions
EXISTS : 'EXISTS' ;
SIZEOF : 'SIZEOF' ;
QUERY : 'QUERY' ;
TYPEOF : 'TYPEOF' ;
ABS : 'ABS' ;
USEDIN : 'USEDIN' ;

IfcType
	: '\'' Version ('.'Identifier)+ '\''
	;

Version 
	: 'IFC' Integer
	; 

fragment
Digit : '0'..'9' ; 

Integer : '-'? Digit+;

LP : '(' ;
RP : ')' ;
LB : '{' ;
RB : '}' ;
COLON : ':' ;
PIPE : '|' ;

// Operators
NOT : 'NOT';
EQ : '=' ;
GT : '>' ;
LT : '<' ;
GTE : '>=' ;
LTE : '<=' ;
NEQ  : '<>' ;
MUL : '*' ;
DIV : '/' ;
ADD : '+' ;
SUB : '-' ;
DEF : ':=' ;
SAME : ':=:' ;
NOT_SAME : ':<>:' ;
INIT : '<*' ;
LAND : '&&' ;
LOR : '||' ;

Scientific
	: Float 'E' '-'? Integer
	;

Float
	: '-'? Digit+ '.' Digit*
	| '-'? Digit+ '.' //See line 3460
	| '-'? '.' Digit*
	;

Identifier 
	: IdLetter (IdLetter | Digit)*
	| '\'' (IdLetter|Digit) (IdLetter|Digit|' ')* '\''
	;

fragment
IdLetter 
	: CapitalLetter
	| LowercaseLetter
	| '_' 
	| '-'
	;

fragment
CapitalLetter
	: 'A'..'Z'
	;

fragment
LowercaseLetter
	: 'a'..'z'
	;

Rules
	: 'RULE ' Identifier .*? 'END_RULE;' -> skip ;

Functions
	: 'FUNCTION ' Identifier .*? 'END_FUNCTION;' -> skip ;

WS 
	: [ \t\r\n\u000c]+ -> skip ;

Comments 
	: '(*' .*? '*)' -> skip ;




