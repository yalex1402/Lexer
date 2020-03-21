# Lexer
This windows form application allows to check a string, validating what words are RESERVED, are OPERATOR, are SYMBOL or  are IDENTIFIER

## Introduction:
Lexer project is a lexical analyzer in C# that analise a simple programming language. Our language is composed by reserved words, operators, symbols and identifiers.

- **Reserved Words:** Those are words that the system use to execute an action


|      Name      | Character Sequence |
|:--------------:|:------------------:|
|   Reserved_if  |         if         |
|  Reserved_else |        else        |
| Reserved_while |        while       |
|  Reserved_for  |         for        |
|  Reserved_next |        next        |
|  Reserved_case |        case        |
| Reserved_print |        print       |
|       ...      |         ...        |


- **Operators:** Those expressing an operation

|       Name      |      Common Name      | Character Sequence |
|:---------------:|:---------------------:|:------------------:|
|      op_add     |          plus         |          +         |
|   op_substract  |         minus         |          -         |
|   op_multiply   |        multiply       |          *         |
|    op_divide    |         divide        |          /         |
|      op_mod     |          mod          |          %         |
|     op_less     |       less than       |          <         |
|   op_lessequal  |   less than or equal  |         <=         |
|    op_greater   |      greater than     |          >         |
| op_greaterequal | greater than or equal |         >=         |
|     op_equal    |         equal         |         ==         |
|   op_notequal   |       not equal       |         !=         |
|      op_not     |          not          |          !         |
|   op_assigment  |       assigment       |          =         |
|      op_and     |      logical and      |         &&         |
|      op_or      |       logical or      |         \|\|         |

- **Symbols:**

|    Name    |    Common Name    | Character Sequence |
|:----------:|:-----------------:|:------------------:|
|  LeftParen |  left parenthesis |          (         |
| RightParen | right parenthesis |          )         |
|  LeftBrace |     left brace    |          {         |
| RightBrace |    right brace    |          }         |
|  Semicolon |     semi-colon    |          ;         |
|    Comma   |       comma       |          ,         |

- **Identifiers:** Exists three type of Identifiers like *numeric identifier*, *string*, *generic identifier*

  * _Numeric identifier_: It is a identifier that contains only numbers for example: 10100
  * _String identifier_: It is any text that start with ' , then any char sequence and finally end the line with '. For example :
  'Hello world!'
  * _Generic identifier_: It is any sequence in a string that start with a char into [a-zA-Z] and end with any char sequence. 
