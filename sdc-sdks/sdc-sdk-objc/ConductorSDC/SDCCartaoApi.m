#import "SDCCartaoApi.h"
#import "SDCQueryParamCollection.h"
#import "SDCResponse.h"
#import "SDCCartao.h"
#import "SDCTransacao.h"
#import "SDCLimite.h"


@interface SDCCartaoApi ()
    @property (readwrite, nonatomic, strong) NSMutableDictionary *defaultHeaders;
@end

@implementation SDCCartaoApi

static SDCCartaoApi* singletonAPI = nil;

#pragma mark - Initialize methods

- (id) init {
    self = [super init];
    if (self) {
        SDCConfiguration *config = [SDCConfiguration sharedConfig];
        if (config.apiClient == nil) {
            config.apiClient = [[SDCApiClient alloc] init];
        }
        self.apiClient = config.apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

- (id) initWithApiClient:(SDCApiClient *)apiClient {
    self = [super init];
    if (self) {
        self.apiClient = apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

+(SDCCartaoApi*) apiWithHeader:(NSString*)headerValue key:(NSString*)key {

    if (singletonAPI == nil) {
        singletonAPI = [[SDCCartaoApi alloc] init];
        [singletonAPI addHeader:headerValue forKey:key];
    }
    return singletonAPI;
}

+(SDCCartaoApi*) sharedAPI {

    if (singletonAPI == nil) {
        singletonAPI = [[SDCCartaoApi alloc] init];
    }
    return singletonAPI;
}

-(void) addHeader:(NSString*)value forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(void) setHeaderValue:(NSString*) value
           forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(unsigned long) requestQueueSize {
    return [SDCApiClient requestQueueSize];
}

#pragma mark - Api Methods

///
/// Bloquear um cart\u00C3\u00A3o.
/// Bloquear um cart\u00C3\u00A3o.
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00C3\u00A3o a ser bloqueado 
///
///  @returns SDCResponse*
///
-(NSNumber*) bloquearUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `bloquearUsingPUT`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `bloquearUsingPUT`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/bloquear"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"PUT"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Cancelar um cart\u00C3\u00A3o
/// Cancelar um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00C3\u00A3o a ser cancelado 
///
///  @returns SDCResponse*
///
-(NSNumber*) cancelarUsingDELETEWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `cancelarUsingDELETE`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `cancelarUsingDELETE`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/cancelar"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"DELETE"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Cria um cart\u00C3\u00A3o
/// Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
///  @param idConta ID da Conta 
///
///  @param cartao Cart\u00C3\u00A3o a ser criado 
///
///  @returns SDCCartao*
///
-(NSNumber*) createUsingPOSTWithIdConta: (NSNumber*) idConta
    cartao: (SDCCartao*) cartao
    completionHandler: (void (^)(SDCCartao* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `createUsingPOST`"];
    }
    
    // verify the required parameter 'cartao' is set
    if (cartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `cartao` when calling `createUsingPOST`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    bodyParam = cartao;
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCCartao*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCCartao*)data, error);
                           }
          ];
}

///
/// Creditar dinheiro em um cart\u00C3\u00A3o
/// Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @param valor Valor a ser creditado 
///
///  @returns SDCResponse*
///
-(NSNumber*) creditarUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `creditarUsingPUT`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `creditarUsingPUT`"];
    }
    
    // verify the required parameter 'valor' is set
    if (valor == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `valor` when calling `creditarUsingPUT`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/creditar"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    bodyParam = valor;
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"PUT"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Desbloquear um cart\u00C3\u00A3o.
/// Desbloquear um determinado cart\u00C3\u00A3o.
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00C3\u00A3o a ser desbloqueado 
///
///  @returns SDCResponse*
///
-(NSNumber*) desbloquearUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `desbloquearUsingPUT`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `desbloquearUsingPUT`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"PUT"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
/// Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param idCartao ID do cart\u00C3\u00A3o 
///
///  @returns NSArray<SDCTransacao>*
///
-(NSNumber*) extratosUsingPOSTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(NSArray<SDCTransacao>* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `extratosUsingPOST`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `extratosUsingPOST`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/extratos"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SDCTransacao>*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((NSArray<SDCTransacao>*)data, error);
                           }
          ];
}

///
/// Retona todos os cart\u00C3\u00A3o de uma conta
/// Consulte todos os carteos de uma determinada conta.
///  @param idConta ID da Conta 
///
///  @returns NSArray<SDCCartao>*
///
-(NSNumber*) getAllUsingGETWithIdConta: (NSNumber*) idConta
    completionHandler: (void (^)(NSArray<SDCCartao>* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `getAllUsingGET`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SDCCartao>*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((NSArray<SDCCartao>*)data, error);
                           }
          ];
}

///
/// Retorna um cart\u00C3\u00A3o
/// Consulte um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cart\u00C3\u00A3o 
///
///  @returns SDCCartao*
///
-(NSNumber*) getOneUsingGETWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCCartao* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `getOneUsingGET`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `getOneUsingGET`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCCartao*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCCartao*)data, error);
                           }
          ];
}

///
/// Retorna o limite do cart\u00C3\u00A3o
/// Consultar o limite de um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @returns SDCLimite*
///
-(NSNumber*) limiteUsingGETWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCLimite* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `limiteUsingGET`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `limiteUsingGET`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/limite"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCLimite*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCLimite*)data, error);
                           }
          ];
}

///
/// Transacionar valores
/// Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @param valor Valor da transa\u00C3\u00A7\u00C3\u00A3o 
///
///  @returns SDCResponse*
///
-(NSNumber*) transacionarUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `transacionarUsingPUT`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `transacionarUsingPUT`"];
    }
    
    // verify the required parameter 'valor' is set
    if (valor == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `valor` when calling `transacionarUsingPUT`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/transacionar"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    bodyParam = valor;
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"PUT"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Transferir valores entre dois cart\u00C3\u00B5es distintos
/// Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
///  @param idConta ID da Conta do cart\u00C3\u00A3o de origem 
///
///  @param idCartao ID do cart\u00C3\u00A3o de origem 
///
///  @param idCartaoDestino ID do cart\u00C3\u00A3o de destino 
///
///  @param valor Valor a ser transferido 
///
///  @returns SDCResponse*
///
-(NSNumber*) transferirUsingPOSTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    idCartaoDestino: (NSNumber*) idCartaoDestino
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponse* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `transferirUsingPOST`"];
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartao` when calling `transferirUsingPOST`"];
    }
    
    // verify the required parameter 'idCartaoDestino' is set
    if (idCartaoDestino == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idCartaoDestino` when calling `transferirUsingPOST`"];
    }
    
    // verify the required parameter 'valor' is set
    if (valor == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `valor` when calling `transferirUsingPOST`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes/{idCartao}/transferir"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    if (idCartao != nil) {
        pathParams[@"idCartao"] = idCartao;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (idCartaoDestino != nil) {
        
        queryParams[@"idCartaoDestino"] = idCartaoDestino;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    bodyParam = valor;
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCResponse*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponse*)data, error);
                           }
          ];
}

///
/// Atualiza um cart\u00C3\u00A3o
/// Atualiza um determinado cart\u00C3\u00A3o
///  @param idConta ID da Conta 
///
///  @param cartao Cart\u00C3\u00A3o a ser atualizado 
///
///  @returns SDCCartao*
///
-(NSNumber*) updateUsingPUTWithIdConta: (NSNumber*) idConta
    cartao: (SDCCartao*) cartao
    completionHandler: (void (^)(SDCCartao* output, NSError* error)) handler {

    
    // verify the required parameter 'idConta' is set
    if (idConta == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `idConta` when calling `updateUsingPUT`"];
    }
    
    // verify the required parameter 'cartao' is set
    if (cartao == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `cartao` when calling `updateUsingPUT`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/v1/contas/{idConta}/cartoes"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (idConta != nil) {
        pathParams[@"idConta"] = idConta;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SDCApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SDCApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"access_token"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    
    bodyParam = cartao;
    

    
    return [self.apiClient requestWithPath: resourcePath
                                    method: @"PUT"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SDCCartao*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCCartao*)data, error);
                           }
          ];
}



@end
