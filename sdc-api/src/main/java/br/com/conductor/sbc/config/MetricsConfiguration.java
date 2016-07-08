
package br.com.conductor.sbc.config;

import javax.annotation.PostConstruct;

import org.junit.Ignore;
import org.springframework.boot.actuate.metrics.repository.InMemoryMetricRepository;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import com.codahale.metrics.MetricRegistry;
import com.codahale.metrics.health.HealthCheckRegistry;
import com.codahale.metrics.jvm.FileDescriptorRatioGauge;
import com.codahale.metrics.jvm.GarbageCollectorMetricSet;
import com.codahale.metrics.jvm.MemoryUsageGaugeSet;
import com.codahale.metrics.jvm.ThreadStatesGaugeSet;
import com.ryantenney.metrics.spring.config.annotation.EnableMetrics;
import com.ryantenney.metrics.spring.config.annotation.MetricsConfigurerAdapter;

import lombok.extern.slf4j.Slf4j;

@Configuration
@EnableMetrics(proxyTargetClass = true)
@Slf4j
@Ignore
public class MetricsConfiguration extends MetricsConfigurerAdapter{

     private static final String PROP_METRIC_REG_JVM_MEMORY = "jvm.memory";

     private static final String PROP_METRIC_REG_JVM_GARBAGE = "jvm.garbage";

     private static final String PROP_METRIC_REG_JVM_THREADS = "jvm.threads";

     private static final String PROP_METRIC_REG_JVM_FILES = "jvm.files";

     public static final String PROP_METRIC_REG_DISK_USAGE = "disk";

     private MetricRegistry metricRegistry = new MetricRegistry();

     private HealthCheckRegistry healthCheckRegistry = new HealthCheckRegistry();

     @Override
     @Bean
     public MetricRegistry getMetricRegistry() {

          return metricRegistry;
     }

     @Override
     @Bean
     public HealthCheckRegistry getHealthCheckRegistry() {

          return healthCheckRegistry;
     }

     @Bean
     public InMemoryMetricRepository metricRepository() {

          return new InMemoryMetricRepository();
     }

     @PostConstruct
     public void init() {

          log.debug("Registering JVM gauges");
          
          metricRegistry.register(PROP_METRIC_REG_JVM_MEMORY, new MemoryUsageGaugeSet());
          metricRegistry.register(PROP_METRIC_REG_JVM_GARBAGE, new GarbageCollectorMetricSet());
          metricRegistry.register(PROP_METRIC_REG_JVM_THREADS, new ThreadStatesGaugeSet());
          metricRegistry.register(PROP_METRIC_REG_JVM_FILES, new FileDescriptorRatioGauge());
          
     }
     
}