#
# Be sure to run `pod lib lint ConductorSDC.podspec' to ensure this is a
# valid spec and remove all comments before submitting the spec.
#
# Any lines starting with a # are optional, but encouraged
#
# To learn more about a Podspec see http://guides.cocoapods.org/syntax/podspec.html
#

Pod::Spec.new do |s|
    s.name             = "ConductorSDC"
    s.version          = "1.0.0"

    s.summary          = "API SDC 2016"
    s.description      = <<-DESC
                         API desenvolvida para a 15\u00C2\u00AA semanda da computa\u00C3\u00A7\u00C3\u00A3o da UFPB em 2016
                         DESC

    s.platform     = :ios, '7.0'
    s.requires_arc = true

    s.framework    = 'SystemConfiguration'
    
    s.homepage     = "https://github.com/swagger-api/swagger-codegen"
    s.license      = "MIT"
    s.source       = { :git => "https://github.com/swagger-api/swagger-codegen.git", :tag => "#{s.version}" }
    s.author       = { "Thiago Sampaio" => "apiteam@swagger.io" }

    s.source_files = 'ConductorSDC/**/*'
    s.public_header_files = 'ConductorSDC/**/*.h'

    s.dependency 'AFNetworking', '~> 2.3'
    s.dependency 'JSONModel', '~> 1.1'
    s.dependency 'ISO8601', '~> 0.3'
end

