#import "SDCCartaoApi.h"
#import "SDCQueryParamCollection.h"
#import "SDCResponseEntity.h"
#import "SDCCartao.h"


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
/// Bloquear um cart\u00EF\u00BF\u00BDo.
/// Bloquear um cart\u00EF\u00BF\u00BDo.
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00EF\u00BF\u00BDo a ser bloqueado 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) bloquearUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Cancelar um cart\u00EF\u00BF\u00BDo
/// Cancelar um cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00EF\u00BF\u00BDo a ser cancelado 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) cancelarUsingDELETEWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Cria um cart\u00EF\u00BF\u00BDo
/// Cria um cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param cartao Cart\u00EF\u00BF\u00BDo a ser criado 
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
/// Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
/// Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @param valor Valor a ser creditado 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) creditarUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Desbloquear um cart\u00EF\u00BF\u00BDo.
/// Desbloquear um cart\u00EF\u00BF\u00BDo.
///  @param idConta ID da Conta 
///
///  @param idCartao Cart\u00EF\u00BF\u00BDo a ser desbloqueado 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) desbloquearUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo
/// Retorna os extratos de todas as transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes de um determinado cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao ID do cart\u00EF\u00BF\u00BDo 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) extratosUsingPOSTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
/// Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
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
/// Retorna um cart\u00EF\u00BF\u00BDo
/// Retorna um cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cart\u00EF\u00BF\u00BDo 
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
/// Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
/// Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) limiteUsingGETWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Transacionar valores
/// Transacionar algum valor utilizando um determinado cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param idCartao ID do Cartao a ser creditado 
///
///  @param valor Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) transacionarUsingPUTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos
/// Transferir valores entre dois cart\u00EF\u00BF\u00BDes
///  @param idConta ID da Conta do cart\u00EF\u00BF\u00BDo de origem 
///
///  @param idCartao ID do cart\u00EF\u00BF\u00BDo de origem 
///
///  @param idCartaoDestino ID do cart\u00EF\u00BF\u00BDo de destino 
///
///  @param valor Valor a ser transferido 
///
///  @returns SDCResponseEntity*
///
-(NSNumber*) transferirUsingPOSTWithIdConta: (NSNumber*) idConta
    idCartao: (NSNumber*) idCartao
    idCartaoDestino: (NSNumber*) idCartaoDestino
    valor: (NSNumber*) valor
    completionHandler: (void (^)(SDCResponseEntity* output, NSError* error)) handler {

    
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
                              responseType: @"SDCResponseEntity*"
                           completionBlock: ^(id data, NSError *error) {
                               handler((SDCResponseEntity*)data, error);
                           }
          ];
}

///
/// Atualiza um cart\u00EF\u00BF\u00BDo
/// Atualiza um cart\u00EF\u00BF\u00BDo
///  @param idConta ID da Conta 
///
///  @param cartao Cart\u00EF\u00BF\u00BDo a ser atualizado 
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
