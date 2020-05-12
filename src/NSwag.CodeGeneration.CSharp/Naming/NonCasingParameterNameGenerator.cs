
using System;
using System.Collections.Generic;
using NJsonSchema.CodeGeneration.CSharp.Naming;

namespace NSwag.CodeGeneration.CSharp.Naming {

    class NonCasingParameterNameGenerator
        : IParameterNameGenerator
    {

        public String
            Generate
        (
            OpenApiParameter
                parameter,
            IEnumerable<OpenApiParameter>
                parameters
        )
            => InvalidCharacters.RemoveAndReplace( parameter.Name );

    }

}
