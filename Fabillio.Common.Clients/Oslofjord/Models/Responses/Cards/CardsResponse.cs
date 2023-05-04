﻿using Newtonsoft.Json;

namespace Fabillio.Common.Clients.Oslofjord.Models.Responses.Cards;

public record CardResponse(
    [property: JsonProperty("balance")] decimal Balance,
    [property: JsonProperty("personKey")] string PersonKey
);
